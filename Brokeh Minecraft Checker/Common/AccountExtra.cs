﻿using xNet;

namespace Brokeh_Minecraft_Checker.Common
{
    public abstract class AccountExtra
    {
        
        /// <summary>
        /// The name of the extra
        /// </summary>
        public string Name { get; }
        
        public AccountExtra(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Checks for the current extra
        /// </summary>
        /// <param name="account">The account to check</param>
        /// <returns></returns>
        public abstract bool CheckExtra(Account account);
    }
}