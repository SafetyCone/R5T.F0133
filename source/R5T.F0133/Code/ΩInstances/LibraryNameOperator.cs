using System;


namespace R5T.F0133
{
    public class LibraryNameOperator : ILibraryNameOperator
    {
        #region Infrastructure

        public static ILibraryNameOperator Instance { get; } = new LibraryNameOperator();


        private LibraryNameOperator()
        {
        }

        #endregion
    }
}
