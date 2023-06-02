using System;

using R5T.T0132;
using R5T.T0186;
using R5T.T0186.Extensions;
using R5T.T0187;
using R5T.T0187.Extensions;
using R5T.T0197;


namespace R5T.F0133
{
    [FunctionalityMarker]
    public partial interface ILibraryDescriptorConversionOperator : IFunctionalityMarker
    {
        public IProjectName Get_DefaultProjectName(ILibraryName libraryName)
        {
            // The default project name is just the library name.
            var output = libraryName.Value.ToProjectName();
            return output;
        }

        public IRepositoryName Get_DefaultRepositoryName(ILibraryName libraryName)
        {
            // The default repository name is just the library name.
            var output = libraryName.Value.ToRepositoryName();
            return output;
        }

        public ISolutionName Get_DefaultSolutionName(ILibraryName libraryName)
        {
            // The default solution name is just the library name.
            var output = libraryName.Value.ToSolutionName();
            return output;
        }
    }
}
