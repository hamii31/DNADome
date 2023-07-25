namespace DNADome.Services
{
    using DNADome.Models;
    using DNADome.Services.Interfaces;
    using System.Text;

    public class DNAReader : IDNAReader
    {
        public DNAFormModel ReadDNA(DNAFormModel formModel)
        {
            string DNA = formModel.DNASequence.ToString();
            List<char> listOfDNA = DNA.ToList();

            StringBuilder output = new StringBuilder();
            StringBuilder compressedCodonOutput = new StringBuilder();

            for(int i = 0; i < listOfDNA.Count; i++)
            {
                if (listOfDNA[i] == ' ')
                {
                    continue;
                }
                switch (listOfDNA[i])
                {
                    case 'M':
                        compressedCodonOutput.AppendLine("ATG");
                        output.AppendLine("Methionine");
                        break;
                    case 'F':
                        compressedCodonOutput.AppendLine("TTY");
                        output.AppendLine("Phenylalanine");
                        break;
                    case 'L':
                        compressedCodonOutput.AppendLine("CTN");
                        output.AppendLine("Leucine");
                        break;
                    case 'I':
                        compressedCodonOutput.AppendLine("ATH");
                        output.AppendLine("Isoleucine");
                        break;
                    case 'V':
                        compressedCodonOutput.AppendLine("GTN");
                        output.AppendLine("Valine");
                        break;
                    case 'S':
                        compressedCodonOutput.AppendLine("TCN");
                        output.AppendLine("Serine");
                        break;
                    case 'P':
                        compressedCodonOutput.AppendLine("CCN");
                        output.AppendLine("Proline");
                        break;
                    case 'T':
                        compressedCodonOutput.AppendLine("ACN");
                        output.AppendLine("Threonine");
                        break;
                    case 'A':
                        compressedCodonOutput.AppendLine("GCN");
                        output.AppendLine("Alanine");
                        break;
                    case 'Y':
                        compressedCodonOutput.AppendLine("TAY");
                        output.AppendLine("Tyrosine");
                        break;
                    case 'H':
                        compressedCodonOutput.AppendLine("H");
                        output.AppendLine("Histidine");
                        break;
                    case 'Q':
                        compressedCodonOutput.AppendLine("CAR");
                        output.AppendLine("Glutamine");
                        break;
                    case 'N':
                        compressedCodonOutput.AppendLine("AAY");
                        output.AppendLine("Asparagine");
                        break;
                    case 'K':
                        compressedCodonOutput.AppendLine("AAR");
                        output.AppendLine("Lysine");
                        break;
                    case 'D':
                        compressedCodonOutput.AppendLine("GAY");
                        output.AppendLine("Aspartic Acid");
                        break;
                    case 'E':
                        compressedCodonOutput.AppendLine("GAR");
                        output.AppendLine("Glutamic Acid");
                        break;
                    case 'C':
                        compressedCodonOutput.AppendLine("TGY");
                        output.AppendLine("Cysteine");
                        break;
                    case 'W':
                        compressedCodonOutput.AppendLine("TGG");
                        output.AppendLine("Tryptophan");
                        break;
                    case 'R':
                        compressedCodonOutput.AppendLine("CGN");
                        output.AppendLine("Arginine");
                        break;
                    case 'G':
                        compressedCodonOutput.AppendLine("GGN");
                        output.AppendLine("Glycine");
                        break;
                    default:
                        break;
                }
                if (i < listOfDNA.Count() - 1)
                {
                    compressedCodonOutput.AppendLine("-");
                    output.AppendLine(", ");
                }
            }
            formModel.AminoAcidsSynthesized = output;
            formModel.CompressedCodonSequence = compressedCodonOutput;

            return formModel;
        }
    }
}
