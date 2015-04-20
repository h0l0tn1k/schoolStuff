using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW04
{
    /// <summary>
    /// Parses arguments from command line
    /// </summary>
    class ArgumentParser
    {
        /// <summary>
        /// Accepted flags, for example -filter -o  etc.
        /// </summary>
        private string[] flags;
        /// <summary>
        /// arguments to be parsed
        /// </summary>
        private string[] args;
        /// <summary>
        /// start token of flag    '-'  -filter   
        /// </summary>
        private char startToken;
        /// <summary>
        /// Assign sign of flag   '=' -filter=".txt" ,   ':' -filter:".txt"
        /// </summary>
        private char assignToken;

        /// <summary>
        /// Argument Parses Class constructor
        /// </summary>
        /// <param name="validFlags">flags to be accepted</param>
        /// <param name="args">arguments to be parsed</param>
        /// <param name="startToken">start sign of the flag</param>
        /// <param name="assignToken">assign sign of the flag</param>
        public ArgumentParser(string[] validFlags,string[] args,char startToken,char assignToken)
        {
            this.startToken = startToken;
            this.assignToken = assignToken;
            this.flags = validFlags;
            this.args = args;
        }

        /// <summary>
        /// Parses Arguments into Valid Flags
        /// </summary>
        /// <returns></returns>
        public Dictionary<Flags, string> GetFlags()
        {
            Dictionary<Flags, string> ret = new Dictionary<Flags, string>();
            foreach (string item in args)
            {
                string[] str = item.Split(new char[] { startToken, assignToken});
                if (str.Length == 3)
                {
                    for (Flags f = (Flags)0; f < Flags.end; f++)
                    { 
                        if (str[1] == f.ToString())
                        {
                            ret.Add(f, str[2]);
                        }
                    }
                }
            }
            return ret;
        }
    }

    /// <summary>
    /// Enum for representing different flags that can be given to program
    /// </summary>
    enum Flags
    {
        folder,
        filter,
        // all additional flags add HERE before 'end' Flag
        end
    }
}
