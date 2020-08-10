namespace Core.Domain
{
    #region Usings

    using System;
    using System.Security;

    #endregion

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
        ///     The user password.
        /// </summary>
        public SecureString Password { get; set; }

        /// <summary>
        ///     The user creation date.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     The user modification date.
        /// </summary>
        public DateTime ModifiedAt { get; set; }

        #endregion
    }
}
