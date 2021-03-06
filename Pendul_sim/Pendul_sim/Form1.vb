﻿Public Class Form1
    'Min og max værdierne for verdenskoordinaterne
    Dim XveV As Single = -25 'cm
    Dim XveH As Single = 25  'cm
    Dim YveB As Single = -110 'cm
    Dim YveT As Single = 0   'cm
    'Min og max værdierne for vindueskoordinater
    Dim XviV As Single = 100
    Dim XviH As Single = 300
    Dim YviB As Single = 540
    Dim YviT As Single = 100
    'Variabler for Exact løsning
    Dim ThetaX As Single = 0
    'Variabler for Euler
    Dim ThetaE_n As Single = 0
    Dim AlphaE_n As Single = 0
    Dim OmegaE_n As Single = 0
    Dim ThetaE_n1 As Single = 0
    Dim AlphaE_n1 As Single = 0
    Dim OmegaE_n1 As Single = 0
    Const OmegaStart As Single = 0
    'Fysiske størrelser
    Const RLod As Single = 5   'cm
    Const Lsnor As Single = 1 'm
    Const g As Single = 9.82   'm/s2
    Const ThetaMax As Single = 0.5 'Radianer
    'Variable til timeren
    Dim Tid As Single = 0            'Den aktuelle tid
    Dim TidsInterval As Integer = 20 'Tidsinterval for timertick i millisekunder
    Dim Delta_t As Single = TidsInterval / 1000 'Delta tid i sekunder

    'Brug Paint på snor og lod med dette i stedet for shapes fra PowerPacks
    Dim SnorP1 As Point     'Snor startpunkt
    Dim SnorP2 As Point     'Snor slutpunkt
    Dim LodP1 As Point      'Lod position
    Dim LodWidth As Integer
    Dim LodHeight As Integer
    Public P_image                  'Bitmap, der tegnes på denne. Defineres senere
    Public P_Graphics As Graphics   'Giver adgang til at tegne
    Dim MyPen As New Pen(Color.Black, 3)     'Pen der tegnes med. Farve og tykkelse kan ændres senere
    Dim MyBrush As New SolidBrush(Color.Red) 'Pensel, der udfyldes med. Farve kan ændres senere


    'Sætter alle fysiske størrelser på plads for lod, snor og transformation
    Private Sub LodStart()
        SaetTransformationsVariabler(True, XveV, XveH, YveB, YveT, XviV, XviH, YviB, YviT)
        Dim P1 As Point  'Til mellemregninger
        Dim P2 As Point
        'Sæt startposition af snor endepunkter (Snor står vandret)
        P1.X = XVerdenToVin(0)
        P1.Y = YVerdenToVin(0)
        P2.X = XVerdenToVin(BeregnX(ThetaMax))
        P2.Y = YVerdenToVin(BeregnY(ThetaMax))
        shpSnor.StartPoint = P1
        shpSnor.EndPoint = P2
        'Sæt startposition og størrelse af lod
        P1.X = XVerdenToVin(P2.X - RLod)
        P1.Y = YVerdenToVin(P2.Y + RLod)
        shpLod.Location = P1
        shpLod.Width = BreddeVerdenToVin(2 * RLod)
        shpLod.Height = HoejdeVerdenToVin(2 * RLod)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LodStart() 'Sætter loddets startværdier
    End Sub

    'Beregner loddets X-pos ud fra vinklen, når snorens startpunkt ligger i (0,0)
    Private Function BeregnX(V As Single) As Single
        Dim X As Single = 0
        X = Math.Sin(ThetaX) * Lsnor
        Return X
    End Function

    'Beregner loddets Y-pos ud fra vinklen, når snorens startpunkt ligger i (0,0)
    Private Function BeregnY(V As Single) As Single
        Dim Y As Single = 0
        Y = Math.Cos(ThetaX) * -Lsnor
        Return Y
    End Function

    'Sætter startværdierne for simulering af exact løsning
    Private Sub StartExact()
        Tid = 0
        Delta_t = TidsInterval / 1000
        ThetaX = ThetaMax
    End Sub

    'Beregner snorens vinkel for exact løsning
    Private Sub BeregnThetaExact()
        ThetaX = ThetaMax * Math.Cos(Math.Sqrt(g / Lsnor) * Tid)
    End Sub

    'Kaldes hver gang der er gået Delta_t sec og beregner positionerne for
    'snor og lod for dette tidspunkdt for den exacte løsning
    Private Sub TimerExact_Tick(sender As Object, e As EventArgs) Handles TimerExact.Tick
        'Punkter til mellemregninger
        Dim Pve As PointF 'Verdenskoordinat i kommatal
        Dim Pvi As Point  'Vindueskoordinat i heltal
        Tid += Delta_t 'Forøger den aktuelle tid med tidsinterval
        'Verdenskoordinaterne for enden af snoren
        BeregnThetaExact()
        Pve.X = BeregnX(ThetaX)

        'Vindueskoordinaterne for enden af snoren

        'Vindueskoordinaterne for loddet

    End Sub

    'Knaptryk for start af simulering af exact løsning
    Private Sub btnStartExact_Click(sender As Object, e As EventArgs) Handles btnStartExact.Click
        'Stop nuværende simulationer
        TimerExact.Stop()
        TimerEuler.Stop()
        'Indlæs værdierne fra tekstfelterne
        TidsInterval = txtTidsInverval.Text
        'Sæt startværdierne
        StartExact()
        'Sæt timerens interval og start simuleringen
        TimerExact.Interval = TidsInterval
        TimerExact.Start()
    End Sub

    'Sætter startværdierne for simulering af Euler løsning
    Private Sub StartEuler()
        'Sat som variabler der kan ændres af bruger
        Tid = 0
        Delta_t = txtTidsInverval.Text
        OmegaE_n = 0
        ThetaE_n = ThetaMax
        AlphaE_n = -g / Lsnor * Math.Sin(ThetaMax)
    End Sub

    'Beregner snorens vinkel for Euler løsning
    Private Sub BeregnThetaEuler()
        'Beregner vinkel, vinkelhastighed og vinkelacceleration for n+1
        'ud fra n-værdier
        OmegaE_n1 = OmegaE_n + AlphaE_n * Delta_t
        ThetaE_n1 = ThetaE_n + OmegaE_n * Delta_t
        AlphaE_n1 = -g / Lsnor * Math.Sin(ThetaE_n1)

        'Sætter n-værdier = n+1 værdierne

        OmegaE_n = OmegaE_n1
        ThetaE_n = ThetaE_n1
        AlphaE_n = AlphaE_n1
    End Sub

    'Beregner snorens vinkel for Euler løsning
    Private Sub btnStartEuler_Click(sender As Object, e As EventArgs) Handles btnStartEuler.Click
        'Stop nuværende simulationer
        TimerExact.Stop()
        TimerEuler.Stop()
        'Indlæs værdierne fra tekstfelterne
        TidsInterval = txtTidsInverval.Text
        'Sæt startværdierne
        StartEuler()
        'Sæt timerens interval og start simuleringen
        TimerEuler.Interval = TidsInterval
        TimerEuler.Start()
    End Sub

    'Kaldes hver gang der er gået Delta_t sec og beregner positionerne for
    'snor og lod for dette tidspunkdt for Euler løsning
    Private Sub TimerEuler_Tick(sender As Object, e As EventArgs) Handles TimerEuler.Tick
        'Punkter til mellemregninger
        Dim Pve As PointF 'Verdenskoordinat i kommatal
        Dim Pvi As Point  'Vindueskoordinat i heltal
        Tid += Delta_t 'Forøger den aktuelle tid med tidsinterval
        'Verdenskoordinaterne for enden af snoren
        BeregnThetaEuler()
        Pve.X = BeregnX(ThetaE_n)

        'Vindueskoordinaterne for enden af snoren

        'Vindueskoordinaterne for loddet

    End Sub

    'Knaptryk for stop af vilkårlig simulering
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        'Stop simuleringen
        Reset()
    End Sub

End Class

