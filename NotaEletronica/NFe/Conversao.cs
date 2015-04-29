namespace NFe
{
    public static class Conversao
    {
        public enum IndicadorDePagamento { ipVista, ipPrazo, ipOutras };
        public enum TipoNF { entrada, saida };
        public enum DestinoOperacao { doInterna = 1, doInterestadual = 2, doExterior = 3 };
        public enum ECFModRef { ECFModRefVazio, ECFModRef2B, ECFModRef2C, ECFModRef2D };
        public enum TipoImpressao
        {
            tiSemGeracao, tiRetrato, tiPaisagem, tiSimplificado, tiNFCe, tiMsgEletronica, tiNFCeA4
        };
        public enum TipoEmissao
        {
            teNormal = 1, teContingencia = 2, teSCAN = 3, teDPEC = 4, teFSDA = 5, teSVCAN = 6,
            teSVCRS = 7, teOffLine = 9
        };
        public enum TipoAmbiente { taProducao = 1, taHomologacao = 2 };
        public enum FinalidadeNFe { fnNormal = 1, fnComplementar = 2, fnAjuste = 3, fnDevolucao = 4 };
        public enum ProcessoEmissao
        {
            peAplicativoContribuinte, peAvulsaFisco, peAvulsaContribuinte, peContribuinteAplicativoFisco
        };
        public enum ConsumidorFinal { cfNao, cfConsumidorFinal };
        public enum PresencaComprador
        {
            pcNao, pcPresencial, pcInternet, pcTeleatendimento, pcEntregaDomicilio, pcOutros = 9
        };
        public enum CRT { crtSimplesNacional = 1, crtSimplesExcessoReceita = 2, crtRegimeNormal = 3 };
        public enum indIEDest { inContribuinte = 1, inIsento = 2, inNaoContribuinte = 9 };
        public enum IndicadorTotal { itSomaTotalNFe, itNaoSomaTotalNFe };
        public enum TipoViaTransp
        {
            tvMaritima = 1, tvFluvial = 2, tvLacustre = 3, tvAerea = 4, tvPostal = 5,
            tvFerroviaria = 6, tvRodoviaria = 7, tvConduto = 8, tvMeiosProprios = 9,
            tvEntradaSaidaFicta = 10, tvCourier = 11, tvHandcarry = 12
        };
        public enum TipoIntermedio { tiContaPropria = 1, tiContaOrdem = 2, tiEncomenda = 3 };
        public enum TipoOperacao
        {
            toVendaConcessionaria = 1, toFaturamentoDireto = 2, toVendaDireta = 3, toOutros = 0
        };
        public enum EspecieVeiculo
        {
            evPassageiro = 1, evCarga = 2, evMisto = 3, evCorrida = 4, evTracao = 5, evEspecial = 6
        };
        public enum CondicaoVeiculo { cvAcabado = 1, cvInacabado = 2, cvSemiAcabado = 3 };
        public enum TipoRestricaoVeiculo
        {
            trvNenhum, trvAlienacaoF, trvAlienacaoM, trvReservaD, trvPenhor, trvOutras = 9
        };
        public enum TipoArma { taUsoPermitido, taUsoRestrito };
    }
}
