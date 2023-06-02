using System;


namespace R5T.F0133
{
    public class LibraryDescriptorConversionOperator : ILibraryDescriptorConversionOperator
    {
        #region Infrastructure

        public static ILibraryDescriptorConversionOperator Instance { get; } = new LibraryDescriptorConversionOperator();


        private LibraryDescriptorConversionOperator()
        {
        }

        #endregion
    }
}
