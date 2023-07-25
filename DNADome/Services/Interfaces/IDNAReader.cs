
namespace DNADome.Services.Interfaces
{
    using DNADome.Models;

    public interface IDNAReader
    {
        DNAFormModel ReadDNA(DNAFormModel formModel);
    }
}
