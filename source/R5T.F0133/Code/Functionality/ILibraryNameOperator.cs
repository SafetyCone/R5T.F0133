using System;

using R5T.T0132;
using R5T.T0186;
using R5T.T0187;
using R5T.T0197;


namespace R5T.F0133
{
    [FunctionalityMarker]
    public partial interface ILibraryNameOperator : IFunctionalityMarker
    {
        public IProjectName Get_DefaultProjectName(ILibraryName libraryName)
        {
            return Instances.LibraryDescriptorConversionOperator.Get_DefaultProjectName(libraryName);
        }

        public IRepositoryName Get_DefaultRepositoryName(ILibraryName libraryName)
        {
            return Instances.LibraryDescriptorConversionOperator.Get_DefaultRepositoryName(libraryName);
        }

        public ISolutionName Get_DefaultSolutionName(ILibraryName libraryName)
        {
            return Instances.LibraryDescriptorConversionOperator.Get_DefaultSolutionName(libraryName);
        }
    }
}
