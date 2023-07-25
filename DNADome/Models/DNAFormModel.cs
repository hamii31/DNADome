using System.Text;

namespace DNADome.Models
{
    public class DNAFormModel
    {
		public DNAFormModel()
		{
			this.AminoAcidsSynthesized = new StringBuilder();
			this.CompressedCodonSequence = new StringBuilder();
		}
        public string DNASequence { get; set; } = null!;
		public StringBuilder AminoAcidsSynthesized { get; set; }
		public StringBuilder CompressedCodonSequence { get; set; }
	}
}
