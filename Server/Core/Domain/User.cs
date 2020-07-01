using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Core.Domain
{
    /// <summary>
    ///     Represents the user entity.
    /// </summary>
    public class User
    {
        #region Properties

        /// <summary>
        ///     The user ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     The username.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     The user password
        /// </summary>
        public SecureString Password { get; set; }

        #endregion
    }
}
