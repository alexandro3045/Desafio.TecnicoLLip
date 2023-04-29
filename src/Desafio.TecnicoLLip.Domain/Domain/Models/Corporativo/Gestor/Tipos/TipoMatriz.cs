using Desafio.TecnicoLLip.Domain.Models.Utility;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos
{
    public class TipoMatriz : Enums<string>
    {
        public static readonly  TipoMatriz CIRJ = new TipoMatriz("01", "CIRJ");
        public static readonly  TipoMatriz MovimentoSindical = new TipoMatriz("02", "Movimento Sindical");
        public static readonly  TipoMatriz ADM026 = new TipoMatriz("03", "ADM026-Convênio Concessão de Descontos a Empresas Não Regimentais");
        public static readonly  TipoMatriz ADM027 = new TipoMatriz("04", "ADM027-Convênio Concessão de Descontos a Associação de Empresas");
        public static readonly  TipoMatriz ADM031 = new TipoMatriz("05", "ADM031-Convênio Concessão de Descontos a Empresas Associadas");
        public static readonly  TipoMatriz ADM028 = new TipoMatriz("06", "ADM028-Convênio Concessão de Valor Regimental a Empresa Não Regimental");
        public static readonly  TipoMatriz MetalSul = new TipoMatriz("08", "MetalSul");
        public static readonly  TipoMatriz AIPERJ = new TipoMatriz("09", "AIPERJ");
        public static readonly  TipoMatriz Llip = new TipoMatriz("10", "FILIAÇÃO Llip");
        public static readonly  TipoMatriz ADM091 = new TipoMatriz("11", "ADM091-Conv Concessão Descontos Empresas Movimento Sindical");
        public static readonly  TipoMatriz ADM092 = new TipoMatriz("12", "ADM092-Conv.Concessão Descontos Empresas Movimento Sindical com SESMT Próprio");
        public static readonly  TipoMatriz ADM098 = new TipoMatriz("13", "ADM098-Concessão Descontos Entidades sem fins lucrativo e não empresarial");

        public TipoMatriz(string key, string displayName) : base(key, displayName) { }
    }
}
