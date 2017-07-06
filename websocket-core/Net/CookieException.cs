using System;

namespace WebSocketCore.Net
{
    /// <summary>
    /// The exception that is thrown when a <see cref="Cookie"/> gets an error.
    /// </summary>
    [Serializable]
    public class CookieException : FormatException
    {
        #region Internal Constructors

        internal CookieException(string message)
            : base(message)
        {
        }

        internal CookieException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        #endregion

        #region Protected Constructors



        #endregion

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CookieException"/> class.
        /// </summary>
        public CookieException()
            : base()
        {
        }

        #endregion

        #region Public Methods



        #endregion

        #region Explicit Interface Implementation



        #endregion
    }
}