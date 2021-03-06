﻿using System.Data.Common;

namespace SqlFu.Providers
{
    public interface IDbProviderExceptions
    {
        /// <summary>
        /// true if the exception signals a timeout or connection limit reached
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        bool IsDbBusy(DbException ex);
        /// <summary>
        /// True if the exception represents a unique constraint violation
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="keyName"></param>
        /// <returns></returns>
        bool IsUniqueViolation(DbException ex, string keyName = "");

        /// <summary>
        /// Returns true if exception contains a message that a table/view/sproc 
        /// already exists
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        bool ObjectExists(DbException ex, string name = null);

        SqlFuConfig SqlFuConfiguration { get; }
    }
}