using System;

using R5T.T0132;
using R5T.T0184;
using R5T.T0184.Extensions;
using R5T.T0187;
using R5T.T0187.Extensions;
using R5T.T0197;


namespace R5T.F0133
{
    [FunctionalityMarker]
    public partial interface ILibraryDescriptionOperator : IFunctionalityMarker
    {
        public IProjectDescription Get_DefaultProjectDescription(ILibraryDescription libraryDescription)
        {
            // The default project description is just the library description.
            var output = libraryDescription.Value.ToProjectDescription();
            return output;
        }

        public IRepositoryDescription Get_DefaultRepositoryDescription(ILibraryDescription libraryDescription)
        {
            // The default repository description is just the library description.
            var output = libraryDescription.Value.ToRepositoryDescription();
            return output;
        }
    }
}
