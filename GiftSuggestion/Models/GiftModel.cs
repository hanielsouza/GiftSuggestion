﻿namespace GiftSuggestion.Models
{
    public class GiftModel
    {
        public int Id { get; private set; }
        public CategoriaEnum Categoria { get; set; }
        public SubcategoriaEnum Subcategoria { get; set; }
        public PublicoAlvoEnum PublicoAlvo { get; set; }
    }

    public enum CategoriaEnum
    {
        Animais = 0,
        Bebes = 1,
        BelezaECuidadoPessoal = 2,
        BrinquedoseHobbies = 3,
        Calcados-RoupasEBolsas = 4,
        CamerasEAcessorios = 5,
        CelularesETelefones = 6,
        Eletrodomesticos = 7, 
        Eletronicos-AudioEVIdeo = 8,
        EsportesEFitness = 9,
        Ferramentas = 10,
        Games = 11,
        Informatica = 12,
        Ingressos = 13,
        InstrumentosMusicais = 14,
        JoiasERelogios = 15,
        Livros-RevistasEComics = 16,
        Musica-FilmesESeriados = 17,
        Saude = 18,
        Servicos = 19,

    }

    public enum SubcategoriaEnum
    {
        //Animais
        AnfibiosERepteis = 0000,
        AvesEAcessorios = 0001,
        Cachorros = 0002,
        Coelhos = 0003,
        Gatos = 0004,
        Insetos = 0005,
        Peixes = 0006,
        Roedores = 0007,
        Outros = 0008,

        //Bebes
        AlimentacaoEAmamentacao = 1000,
        AlimentosParaBebes = 1001,
        AndadoresEMiniVeIculos  = 1002,
        BanhoDoBebe  = 1003,
        BrinquedosParaBebes = 1004,
        Cercadinho = 1005,
        ChupetasEMordedores = 1006,
        HigieneECuidadosComOBebe = 1007,
        Maternidade = 1008,
        PasseioDoBebe = 1009,
        QuartoDoBebe = 1010,
        RoupasDeBebe = 1011,
        SaudeDoBebe = 1012,
        SegurancaParaBebe = 1013,
        Outros = 1014,

        //Beleza e Cuidado Pessoal
        ArtefatosParaCabelo = 2000,
        ArtigosParaCabeleireiros = 2001,
        Barbearia = 2002,
        CuidadosComAPele = 2003,
        CuidadosComOCabelo = 2004,
        Depilacao = 2005,
        Farmacia = 2006,
        HigienePessoal = 2007,
        ManicureEPedicure = 2008,
        Maquiagem = 2009,
        PerfumesEFragrancias = 2010,
        TratamentosDeBeleza = 2011,
        Outros = 2012,

        //Brinquedos e Hobbies
        AlbunsEFigurinhas = 3000,
        Anti-stressEEngenho = 3001,
        ArLivreEPlayground = 3002,
        ArtesEAtividades = 3003,
        BonecosEBonecas = 3004,
        BrinquedosDeFazDeConta = 3005,
        BrinquedosDeMontar = 3006,
        BrinquedosDePegadinhas = 3007,
        BrinquedosDePraiaEPiscina = 3008,
        BrinquedosEletronicos = 3009,
        BrinquedosParaBebes = 3010,
        CasinhasEBarracas = 3011,
        FantochesEMarionetas = 3012,
        Hobbies = 3013,
        InstrumentosMusicais = 3014,
        JogosDeSalao = 3015,
        JogosDeTabuleiroECartas = 3016,
        LancadoresDeBrinquedo = 3017,
        MesasECadeiras = 3018,
        MiniVeIculosEBicicletas = 3019,
        PatinsESkates = 3020,
        Pelucias = 3021,
        PiscinasEInflaveis = 3022,
        VeIculosDeBrinquedo = 3023,
        Outros = 3024,

        //Calcados-RoupasEBolsas
        AcessoriosDeModa = 4000,
        Agasalhos = 4001,
        BermudasEShorts = 4002,
        Blusas = 4003,
        Calcados = 4004,
        Calcas = 4005,
        Camisas = 4006,
        Camisetas = 4007,
        IndumentariaLaboralEEscolar = 4008,
        Kimonos = 4009,
        KitsDeConjuntosDeRoupa = 4010,
        Leggings = 4011,
        Macacao = 4012,
        MalasEBolsas = 4013,
        ModaFitness = 4014,
        ModaIntimaELingerie = 4015,
        ModaPraia = 4016,
        RoupasParaBebes = 4017,
        Saias = 4018,
        Ternos = 4019,
        Vestidos = 4020,
        Outros = 4021,

        //CamerasEAcessorios
        AcessoriosParaCameras = 5000,
        AlbunsEPorta-retratos = 5001,
        Cabos = 5002,
        Cameras = 5003,
        DronesEAcessorios = 5004,
        EquipamentoDeRevelacao = 5005,
        Filmadoras = 5006,
        InstrumentosOpticos = 5007,
        LentesEFiltros = 5008,
        PecasParaCameras = 5009,
        Outros = 5010,

        //CelularesETelefones
        AcessoriosParaCelulares = 6000,
        CelularesESmartphones = 6001,
        OculosDeRealidadeVirtual = 6002,
        RadioComunicadores = 6003,
        SmartwatchesEAcessorios = 6004,
        TarifadoresECabines = 6005,
        TelefoniaFixaESemFio = 6006,
        Outros = 6007,

        //Eletrodomesticos
        ArEVentilacao = 7000,
        BebedourosEPurificadores = 7001,
        CuidadoPessoal = 7002,
        FornosEFogoes = 7003,
        Lavadores = 7004,
        PequenosEletrodomesticos = 7005,
        Refrigeracao = 7006,
        Outros = 7007,

        //Eletronicos-AudioEVIdeo
        AcessoriosParaAudioEVIdeo = 8000,
        AcessoriosParaTV = 8001,
        AparelhosDVDEBluray = 8002,
        Audio = 8003,
        BolsasEEstojos = 8004,
        Cabos = 8005,
        ComponentesEletronicos = 8006,
        ControlesRemotos = 8007,
        DronesEAcessorios = 8008
        MediaStreaming = 8009,
        PecasParaTV = 8010,
        PilhasECarregadores = 8011,
        ProjetoresETelas = 8012,
        Televisores = 8013,
        OutrosEletronicos = 8014,

        //EsportesEFitness
        ArtesMarciaisEBoxe = 9000,
        Badminton = 9001,
        Baseball = 9002,
        Basquete = 9003,
        Camping-CacaEPesca = 9004,
        Canoas-CaiaquesEInflaveis = 9005,
        Ciclismo = 9006,
        Equitacao = 9007,
        Esgrima = 9008,
        EsquiESnowboard = 9009,
        FitnessEMusculacao = 9010,
        Futebol = 9011,
        FutebolAmericano = 9012,
        Golfe = 9013,
        Handebol = 9014,
        Hockey = 9015,
        JogosDeSalao = 9016,
        Kitesurf = 9017,
        Mergulho = 9018,
        ModaFitness = 9019,
        MonitoresEsportivos = 9020,
        Natacao = 9021,
        Paintball = 9022,
        Parapente = 9023,
        PatInESkateboard = 9024,
        PatinetesEScooters = 9025,
        PilatesEYoga = 9026,
        Rapel-MontanhismoEEscalada = 9027,
        Rugby = 9028,
        Slackline = 9029,
        SuplementosEShakers = 9030,
        SurfEBodyboard = 9031,
        Tenis = 9032,
        TenisESquash = 9033,
        TiroEsportivo = 9034,
        Volei = 9035,
        WakeboardEEsquIAcuatico = 9036,
        Windsurfe = 9037,
        Outros = 9038,

        //Ferramentas
        AcessoriosParaFerramentas = 10000,
        CaixasEOrganizadores = 10001,
        FerramentasEletricas = 10002,
        FerramentasIndustriais = 10003,
        FerramentasManuais = 10004,
        FerramentasParaJardim = 10005,
        FerramentasPneumaticas = 10006,
        MedicoesEInstrumentacao = 10007,
        Outros = 10008,

        //Games
        AcessoriosParaConsoles = 11000,
        AcessoriosParaPCGaming = 11001,
        Consoles = 11002,
        FliperamasEArcade = 11003,
        PecasParaConsoles = 11004,
        VideoGames = 11005,
        Outros = 11006,

        //Informatica
        AcessoriosDeAntiestatica = 12000
        AcessoriosParaPCGaming = 12001
        Armazenamento = 12002
        CabosEHubsUSB = 12003
        ComponentesParaPC = 12004
        ConectividadeERedes = 12005
        EstabilizadoresENoBreaks = 12006
        Impressao = 12007
        LeitoresEScanners = 12008
        LimpezaDePCs = 12009
        MonitoresEAcessorios = 12010
        PalmsEHandhelds = 12011
        PCDeMesa = 12012
        PerifericosParaPC = 12013
        PortateisEAcessorios = 12014
        ProjetoresETelas = 12015
        Software = 12016
        TabletsEAcessorios = 12017
        Outros = 12018

        //Ingressos
        EventosABenefIcio = 13000,
        EventosEsportivos = 13001,
        Exposicoes = 13002,
        IngressosDeColecao = 13003,
        Shows = 13004,
        TeatroECultura = 13005,
        OutrosIngressos = 13006,

        //InstrumentosMusicais
        BateriasEPercussao = 14000
        CaixasDeSom = 14001
        EquipamentoParaDJs = 14002
        EstudioDeGravacao = 14003
        InstrumentosDeCorda = 14004
        InstrumentosDeSopro = 14005
        Metronomos = 14006
        MicrofonesEAmplificadores = 14007
        PartiturasELetras = 14008
        PedaisEAcessorios = 14009
        PianosETeclados = 14010
        Outros = 14011


        //JoiasERelogios
        AcessoriosParaRelogios = 15000,
        ArtigosDeJoalharia = 15001,
        CanetasELapiseirasDeLuxo = 15002,
        JoiasEBijuterias = 15003,
        PedrasPreciosas = 15004,
        Piercings = 15005,
        PortaJoias = 15006,
        Relogios = 15007,
        Outros = 15008,

        //Livros-RevistasEComics
        Catalogos = 16000,
        EBOOKS = 16001,
        HQs = 16002,
        Livros = 16003,
        Manga = 16004,
        Revistas = 16005,
        Outros = 16006,

        //Musica-FilmesESeriados
        Cursos = 17000,
        Filmes = 17001,
        Musica = 17002,
        Seriados = 17003,
        Outros = 17004,

        //Saude
        CuidadodaSaude = 18000,
        EquipamentoMedico = 18001,
        Massagem = 18002,
        Mobilidade = 18003,
        Ortopedia = 18004,
        SuplementosAlimentares = 18005,
        TerapiasAlternativas = 18006,
        Outros = 18007,

        //Servicos
        AcademiaEEsportes = 19000
        Animais = 19001
        Beleza-EsteticaEBemEstar = 19002
        Educacao = 19003
        FestasEEventos = 19004
        Gastronomia = 19005
        GraficasEImpressao = 19006
        Lar = 19007
        MarketingEInternet = 19008
        OutrosProfissionais = 19009
        OutrosServicos = 19010
        Saude = 19011
        SuporteTecnico = 19012
        VeIculosETransportes = 19013
        Vestuario = 19014
        ViagensETurismo = 19015


    }

    public enum PublicoAlvoEnum
    {
        Femmino = 0,
        Masculino = 1,
        Juvenil = 2,
        Crianca = 3,
        Bebe = 4,
    }
}