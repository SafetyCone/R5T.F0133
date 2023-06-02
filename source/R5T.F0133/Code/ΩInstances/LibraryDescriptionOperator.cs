using System;


namespace R5T.F0133
{
    public class LibraryDescriptionOperator : ILibraryDescriptionOperator
    {
        #region Infrastructure

        public static ILibraryDescriptionOperator Instance { get; } = new LibraryDescriptionOperator();


        private LibraryDescriptionOperator()
        {
        }

        #endregion
    }
}
