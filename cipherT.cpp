#include <iostream>
#include <fstream>
#include <cstring>
#include <list>
#include <cstdlib>

using namespace std;

typedef unsigned char BYTE;

//
// CipherT - TYPE I.
//
typedef struct _precompTable1 {
    BYTE encryptTable[256];
} precompTable1;

void makeTable1(BYTE key, precompTable1* pTable) {
    for (int i = 0; i < 256; i++) pTable->encryptTable[i] = i ^ key;
}
BYTE encrypt1(BYTE data, precompTable1* pTable) {
    return pTable->encryptTable[data];
}

//
// CipherT - TYPE II.
//
typedef struct _precompTable2 {
    BYTE encryptTable[256*256];
} precompTable2;

void makeTable2(int key, precompTable2* pTable) {
    for (int i = 0; i < 256*256; i++) {
        switch (i % 4) {
        case 0: pTable->encryptTable[i] = i ^ (key & 0xff); break;
        case 1: pTable->encryptTable[i] = i ^ ((key >> 8) & 0xff); break;
        case 2: pTable->encryptTable[i] = i ^ ((key >> 16) & 0xff); break;
        case 3: pTable->encryptTable[i] = i ^ ((key >> 24) & 0xff); break;
        }
    }
}
BYTE encrypt2(BYTE data1, BYTE data2, precompTable2* pTable) {
    int offset = data1 | (data2 << 8);
    return pTable->encryptTable[offset];
}

//
// CipherT - TYPE III.
//
typedef struct _precompTable3 {
    BYTE encryptTable_first[256];
    BYTE encryptTable_second[256];
} precompTable3;

/**
    This function generates random bijection on 8 bits
    Following formula will be valid: invBiject[biject[data]] == data
    No need to study this function in details for cryptanalysis of CipherT - there is no hidden catch
*/
void generate8X8Bijection(BYTE biject[256], BYTE invBiject[256]) {
    list<BYTE>  freeList;
    list<BYTE>::iterator  iter;
    int         j;
    int         i;
    BYTE        target;
    BYTE         pos;
    //
    //  RANDOM 8x8 BIJECTION
    //
    for (j = 0; j < 256; j++) freeList.push_back(j);
    // FOR EACH POSSIBLE VALUE FROM 0 TO 255
    for (j = 0; j < 256; j++) {
        // CHOOSE RANDOMLY ONE NUMBER FROM UNUSED TARGETS
        pos = rand() % freeList.size();
        iter = freeList.begin();
        for (i = 0; i < pos; i++) iter++;
        // ASSIGN CHOOSEN TARGET AND REMOVE FROM FREE LIST
        target = *iter;
        biject[j] = target;
        invBiject[target] = j;
        freeList.erase(iter);
    }
}

void makeTable3(BYTE key1, BYTE key2, precompTable3* pTable) {
    BYTE random_bijection[256];
    BYTE random_bijection_inv[256];
    generate8X8Bijection(random_bijection, random_bijection_inv);

    for (int i = 0; i < 256; i++) {
        pTable->encryptTable_first[i] = random_bijection[i ^ key1];
        pTable->encryptTable_second[pTable->encryptTable_first[i]] = random_bijection_inv[pTable->encryptTable_first[i]] ^ key2;
    }
}
BYTE encrypt3(BYTE data, precompTable3* pTable) {
    BYTE    result = pTable->encryptTable_first[data];
    result = pTable->encryptTable_second[result];
    return result;
}

// Global structures filled in processInSecureEnvironment (secure environment)
// and used in processInAttackerMachine (insecure environment)
precompTable1   table1;
precompTable2   table2;
precompTable3   table3;

void processInSecureEnvironment() {
    BYTE     key1;
    int      key2;
    BYTE     key3_1;
    BYTE     key3_2;

    memset(&table1, 0, sizeof(precompTable1));
    memset(&table2, 0, sizeof(precompTable2));
    memset(&table3, 0, sizeof(precompTable3));

    cout << "### CipherT - Type I. ###" << endl;
    cout << "Type your key (0...255): ";
    cin >> key1;
    cout << endl << "Generating table type I...";
    makeTable1(key1, &table1);
    cout << "done"  << endl;

    cout << "### CipherT - Type II. ###" << endl;
    cout << "Type your key (one signed integer, 0...2^32): ";
    cin >> key2;
    cout << endl << "Generating table type II...";
    makeTable2(key2, &table2);
    cout << "done"  << endl;

    cout << "### CipherT - Type III. ###" << endl;
    cout << "Type your first key (one byte, 0...255): ";
    //cin >> key3_1;
    cout << endl << "Type your second key (one byte, 0...255): ";
    cin >> key3_2;
    cout << endl << "Generating table type III...";
    makeTable3(key3_1, key3_2, &table3);
    cout << "done"  << endl;
}

void processInAttackerMachine() {
    BYTE     data;
    BYTE     data2;

    cout << "### CipherT - Type I. ###" << endl;
    cout << "Type input data to encrypt (one byte, 0...255): ";
    cin >> data;
    cout << endl << "Data '" << hex << (int) data << "' encrypted to '" << hex << (int) encrypt1(data, &table1) << "'" << endl;

    cout << "### CipherT - Type II. ###" << endl;
    cout << "Type input data to encrypt (first part) (one byte, 0...255): ";
    //cin >> data;
    cout << endl << "Type input data to encrypt (second part) (one byte, 0...255): ";
    cin >> data2;
    cout << endl << "Data '" << hex << (int) data << "','" << hex << (int) data2 << "' encrypted to '" << hex << (int) encrypt2(data, data2, &table2) << "'" << endl;

    cout << "### CipherT - Type III. ###" << endl;
    cout << "Type input data to encrypt (one byte, 0...255): ";
    cin >> data;
    cout << endl << "Data '" << hex << (int) data << "' encrypted to '" << hex << (int) encrypt3(data, &table3) << "'" << endl;
}

int main() {
    processInSecureEnvironment();
    cout << endl << endl;
    processInAttackerMachine();

	for (int i = 0; i < 256; i++)
	{
		cout << table1[i] << " ";
		if (i % 16 == 0)
			cout << endl;
	}

    return 0;
}

