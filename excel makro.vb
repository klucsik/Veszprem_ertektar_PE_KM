Sub értéktár_exportálása_kml_térképfájlba()
'
Open "Veszprém értéktára.kml" For Output As #1
Print #1, "<?xml version='1.0' encoding='UTF-8'?>"
Print #1, "<kml xmlns='http://www.opengis.net/kml/2.2'>"
Print #1, "  <Document>"
Print #1, "    <name>Veszprém értéktára</name>"
Print #1, "   "
Print #1, " <description> A térkép egyrészt Veszprém városának épített értékeit típus és védettségi fok szerint, másrészt a természetvédelmi területeket ábrázolja. </description>"

Print #1, "    <Style id='icon-1580-0288D1-nodesc-normal'><IconStyle><color>ffd18802</color><scale>1</scale><Icon><href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href></Icon></IconStyle><LabelStyle><scale>0</scale></LabelStyle><BalloonStyle><text><![CDATA[<h3>$[name]</h3>]]></text></BalloonStyle>    </Style>"
Print #1, "    <Style id='icon-1580-0288D1-nodesc-highlight'>      <IconStyle>        <color>ffd18802</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>1</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
Print #1, "    <StyleMap id='icon-1580-0288D1-nodesc'>      <Pair>        <key>normal</key>        <styleUrl>#icon-1580-0288D1-nodesc-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#icon-1580-0288D1-nodesc-highlight</styleUrl>      </Pair>    </StyleMap>"
Print #1, "    <Style id='icon-1580-880E4F-nodesc-normal'>      <IconStyle>        <color>ff4f0e88</color>        <scale>1</scale>       <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>       </Icon>      </IconStyle>      <LabelStyle>        <scale>0</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
Print #1, "    <Style id='icon-1580-880E4F-nodesc-highlight'>      <IconStyle>        <color>ff4f0e88</color>        <scale>1</scale>        <Icon>         <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>       </Icon>      </IconStyle>      <LabelStyle>        <scale>1</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
Print #1, "    <StyleMap id='icon-1580-880E4F-nodesc'>      <Pair>        <key>normal</key>        <styleUrl>#icon-1580-880E4F-nodesc-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#icon-1580-880E4F-nodesc-highlight</styleUrl>      </Pair>   </StyleMap>"
Print #1, "    <Style id='icon-1580-F9A825-labelson'>      <IconStyle>        <color>ff25a8f9</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>     </IconStyle>"
Print #1, "    </Style>"
Print #1, "    <Style id='icon-1599-0288D1-normal'>     <IconStyle>        <color>ffd18802</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>0</scale>      </LabelStyle>    </Style>"
 Print #1, " <Style id='icon-1599-0288D1-highlight'>      <IconStyle>        <color>ffd18802</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>1</scale>      </LabelStyle>    </Style>"
 Print #1, " <StyleMap id='icon-1599-0288D1'>      <Pair>        <key>normal</key>        <styleUrl>#icon-1599-0288D1-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#icon-1599-0288D1-highlight</styleUrl>      </Pair>    </StyleMap>"
Print #1, "    <Style id='icon-1599-880E4F-nodesc-normal'>      <IconStyle>        <color>ff4f0e88</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>0</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
Print #1, "    <Style id='icon-1599-880E4F-nodesc-highlight'>      <IconStyle>        <color>ff4f0e88</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>1</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
 Print #1, "   <StyleMap id='icon-1599-880E4F-nodesc'>      <Pair>        <key>normal</key>        <styleUrl>#icon-1599-880E4F-nodesc-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#icon-1599-880E4F-nodesc-highlight</styleUrl>      </Pair>    </StyleMap>"
Print #1, "    <Style id='icon-1599-F9A825-labelson'>      <IconStyle>        <color>ff25a8f9</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>       </Icon>      </IconStyle>    </Style>"
 Print #1, "   <Style id='icon-1603-0288D1-normal'>      <IconStyle>       <color>ffd18802</color>       <scale>1</scale>       <Icon>         <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>       </Icon>      </IconStyle>      <LabelStyle>        <scale>0</scale>      </LabelStyle>    </Style>"
 Print #1, "   <Style id='icon-1603-0288D1-highlight'>      <IconStyle>        <color>ffd18802</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>1</scale>      </LabelStyle>    </Style>"
 Print #1, "   <StyleMap id='icon-1603-0288D1'>      <Pair>        <key>normal</key>        <styleUrl>#icon-1603-0288D1-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#icon-1603-0288D1-highlight</styleUrl>      </Pair>    </StyleMap>"
 Print #1, "   <Style id='icon-1603-880E4F-nodesc-normal'>      <IconStyle>        <color>ff4f0e88</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>0</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
 Print #1, "   <Style id='icon-1603-880E4F-nodesc-highlight'>      <IconStyle>        <color>ff4f0e88</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>1</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
 Print #1, "   <StyleMap id='icon-1603-880E4F-nodesc'>      <Pair>        <key>normal</key>        <styleUrl>#icon-1603-880E4F-nodesc-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#icon-1603-880E4F-nodesc-highlight</styleUrl>      </Pair>    </StyleMap>"
Print #1, "    <Style id='icon-1603-F9A825-labelson'>      <IconStyle>        <color>ff25a8f9</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>    </Style>"
 Print #1, "   <Style id='icon-1753-0288D1-nodesc-normal'>      <IconStyle>        <color>ffd18802</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>0</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>   </Style>"
Print #1, "   <Style id='icon-1753-0288D1-nodesc-highlight'>      <IconStyle>        <color>ffd18802</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>1</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
 Print #1, "   <StyleMap id='icon-1753-0288D1-nodesc'>      <Pair>        <key>normal</key>        <styleUrl>#icon-1753-0288D1-nodesc-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#icon-1753-0288D1-nodesc-highlight</styleUrl>      </Pair>    </StyleMap>"
  Print #1, "  <Style id='icon-1753-880E4F-nodesc-normal'>      <IconStyle>        <color>ff4f0e88</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>0</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
 Print #1, "   <Style id='icon-1753-880E4F-nodesc-highlight'>      <IconStyle>        <color>ff4f0e88</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>      <LabelStyle>        <scale>1</scale>      </LabelStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
  Print #1, "  <StyleMap id='icon-1753-880E4F-nodesc'>      <Pair>        <key>normal</key>        <styleUrl>#icon-1753-880E4F-nodesc-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#icon-1753-880E4F-nodesc-highlight</styleUrl>      </Pair>    </StyleMap>"
 Print #1, "   <Style id='icon-1753-F9A825-labelson'>      <IconStyle>        <color>ff25a8f9</color>        <scale>1</scale>        <Icon>          <href>http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png</href>        </Icon>      </IconStyle>    </Style>"
    
    
  Print #1, "   "
  
  Print #1, " <Style id='poly-E65100-1200-23-nodesc-normal'>      <LineStyle>        <color>ff0051e6</color>        <width>1.2</width>      </LineStyle>      <PolyStyle>        <color>170051e6</color>        <fill>1</fill>        <outline>1</outline>      </PolyStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
  Print #1, " <Style id='poly-E65100-1200-23-nodesc-highlight'>      <LineStyle>        <color>ff0051e6</color>        <width>1.8</width>      </LineStyle>      <PolyStyle>        <color>170051e6</color>        <fill>1</fill>        <outline>1</outline>      </PolyStyle>      <BalloonStyle>        <text><![CDATA[<h3>$[name]</h3>]]></text>      </BalloonStyle>    </Style>"
  Print #1, "  <StyleMap id='poly-E65100-1200-23-nodesc'>      <Pair>        <key>normal</key>        <styleUrl>#poly-E65100-1200-23-nodesc-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#poly-E65100-1200-23-nodesc-highlight</styleUrl>      </Pair>    </StyleMap>"
    
Print #1, "  <Style id='poly-CCCCCC-5000-0-normal'>    <LineStyle>        <color>ffcccccc</color>        <width>5</width>      </LineStyle>      <PolyStyle>        <color>00cccccc</color>        <fill>1</fill>        <outline>1</outline>      </PolyStyle>    </Style>"
 Print #1, "   <Style id='poly-CCCCCC-5000-0-highlight'>      <LineStyle>        <color>ffcccccc</color>        <width>7.5</width>      </LineStyle>      <PolyStyle>        <color>00cccccc</color>        <fill>1</fill>        <outline>1</outline>      </PolyStyle>    </Style>"
 Print #1, "   <StyleMap id='poly-CCCCCC-5000-0'>      <Pair>        <key>normal</key>        <styleUrl>#poly-CCCCCC-5000-0-normal</styleUrl>      </Pair>      <Pair>        <key>highlight</key>        <styleUrl>#poly-CCCCCC-5000-0-highlight</styleUrl>      </Pair>    </StyleMap>"
    
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
    Worksheets("Épületek").Activate 'épületek
    
Print #1, "    <Folder>"
Print #1, "      <name>" & "Épületek" & "</name>"

Dim Sor, Oszlop As Integer
Sor = 2

Do Until Cells(Sor, 1) = Empty


Print #1, "      <Placemark>"
Print #1, "        <name>" & Cells(Sor, 2) & "</name>"
Oszlop = 1
Print #1, "        <description><![CDATA[" & Cells(Sor, 10) & "]]></description>"


If Cells(Sor, 9) = "műemlék" Then
Print #1, "        <styleUrl>#icon-1603-880E4F-nodesc</styleUrl>"
End If
If Cells(Sor, 9) = "Műemlék" Then
Print #1, "        <styleUrl>#icon-1603-880E4F-nodesc</styleUrl>"
End If

If Cells(Sor, 9) = "Helyi/történelmi érték" Then
Print #1, "        <styleUrl>#icon-1603-F9A825-labelson</styleUrl>"
End If
If Cells(Sor, 9) = "Helyi/történelmi emlék" Then
Print #1, "        <styleUrl>#icon-1603-F9A825-labelson</styleUrl>"
End If

If Cells(Sor, 9) = "nem védett" Then
Print #1, "        <styleUrl>#icon-1603-0288D1</styleUrl>"
End If

Print #1, "        <ExtendedData>"

Oszlop = 1
Do Until Cells(1, Oszlop) = "STOP"
Print #1, "          <Data name='" & Cells(1, Oszlop) & "' > """
Print #1, "            <value>" & Cells(Sor, Oszlop) & "</value>"
Print #1, "          </Data>"

Oszlop = Oszlop + 1
Loop
Print #1, "        </ExtendedData>"
Print #1, "        <Point>"
Print #1, "          <coordinates>"
Print #1, "           " & Cells(Sor, 6) & "," & Cells(Sor, 5) & "," & "0"
Print #1, "          </coordinates>"
Print #1, "        </Point>"
Print #1, "      </Placemark>"
        
Sor = Sor + 1
Loop
Print #1, "    </Folder>"





    Worksheets("Szobrok").Activate 'szobrok
    
Print #1, "    <Folder>"
Print #1, "      <name>" & "Szobrok" & "</name>"

Sor = 2

Do Until Cells(Sor, 1) = Empty


Print #1, "      <Placemark>"
Print #1, "        <name>" & Cells(Sor, 2) & "</name>"
Oszlop = 1
Print #1, "        <description><![CDATA[" & Cells(Sor, 10) & "]]></description>"


If Cells(Sor, 9) = "műemlék" Then
Print #1, "        <styleUrl>#icon-1599-880E4F-nodesc</styleUrl>"
End If

If Cells(Sor, 9) = "Műemlék" Then
Print #1, "        <styleUrl>#icon-1599-880E4F-nodesc</styleUrl>"
End If

If Cells(Sor, 9) = "Helyi/történelmi érték" Then
Print #1, "         <styleUrl>#icon-1599-F9A825-labelson</styleUrl>"
End If
If Cells(Sor, 9) = "Helyi/történelmi emlék" Then
Print #1, "         <styleUrl>#icon-1599-F9A825-labelson</styleUrl>"
End If

If Cells(Sor, 9) = "nem védett" Then
Print #1, "        <styleUrl>#icon-1599-0288D1</styleUrl>"
End If

Print #1, "        <ExtendedData>"

Oszlop = 1
Do Until Cells(1, Oszlop) = "STOP"
Print #1, "          <Data name='" & Cells(1, Oszlop) & "' > """
Print #1, "            <value>" & Cells(Sor, Oszlop) & "</value>"
Print #1, "          </Data>"

Oszlop = Oszlop + 1
Loop
Print #1, "        </ExtendedData>"
Print #1, "        <Point>"
Print #1, "          <coordinates>"
Print #1, "           " & Cells(Sor, 6) & "," & Cells(Sor, 5) & "," & "0"
Print #1, "          </coordinates>"
Print #1, "        </Point>"
Print #1, "      </Placemark>"
        
Sor = Sor + 1
Loop
Print #1, "    </Folder>"

 Worksheets("Kutak").Activate 'kutak
    
Print #1, "    <Folder>"
Print #1, "      <name>" & "Kutak" & "</name>"

Sor = 2

Do Until Cells(Sor, 1) = Empty


Print #1, "      <Placemark>"
Print #1, "        <name>" & Cells(Sor, 2) & "</name>"
Oszlop = 1
Print #1, "        <description><![CDATA[" & Cells(Sor, 10) & "]]></description>"


If Cells(Sor, 9) = "műemlék" Then
Print #1, "        <styleUrl>#icon-1580-880E4F-nodesc</styleUrl>"
End If
If Cells(Sor, 9) = "Műemlék" Then
Print #1, "        <styleUrl>#icon-1580-880E4F-nodesc</styleUrl>"
End If

If Cells(Sor, 9) = "Helyi/történelmi érték" Then
Print #1, "         <styleUrl>#icon-1580-F9A825-labelson</styleUrl>"
End If
If Cells(Sor, 9) = "Helyi/történelmi emlék" Then
Print #1, "         <styleUrl>#icon-1580-F9A825-labelson</styleUrl>"
End If

If Cells(Sor, 9) = "nem védett" Then
Print #1, "        <styleUrl>#icon-1580-0288D1-nodesc</styleUrl>"
End If

Print #1, "        <ExtendedData>"

Oszlop = 1
Do Until Cells(1, Oszlop) = "STOP"
Print #1, "          <Data name='" & Cells(1, Oszlop) & "' > """
Print #1, "            <value>" & Cells(Sor, Oszlop) & "</value>"
Print #1, "          </Data>"

Oszlop = Oszlop + 1
Loop
Print #1, "        </ExtendedData>"
Print #1, "        <Point>"
Print #1, "          <coordinates>"
Print #1, "           " & Cells(Sor, 6) & "," & Cells(Sor, 5) & "," & "0"
Print #1, "          </coordinates>"
Print #1, "        </Point>"
Print #1, "      </Placemark>"
        
Sor = Sor + 1
Loop
Print #1, "    </Folder>"

 Worksheets("Emléktáblák").Activate 'emléktáblák
    
Print #1, "    <Folder>"
Print #1, "      <name>" & "Emléktáblák" & "</name>"

Sor = 2

Do Until Cells(Sor, 1) = Empty


Print #1, "      <Placemark>"
Print #1, "        <name>" & Cells(Sor, 2) & "</name>"
Oszlop = 1
Print #1, "        <description><![CDATA[" & Cells(Sor, 10) & "]]></description>"


If Cells(Sor, 9) = "műemlék" Then
Print #1, "        <styleUrl>#icon-1753-880E4F-nodesc</styleUrl>"
End If
If Cells(Sor, 9) = "Műemlék" Then
Print #1, "        <styleUrl>#icon-1753-880E4F-nodesc</styleUrl>"
End If

If Cells(Sor, 9) = "Helyi/történelmi érték" Then
Print #1, "         <styleUrl>#icon-1753-F9A825-labelson</styleUrl>"
End If
If Cells(Sor, 9) = "Helyi/történelmi emlék" Then
Print #1, "         <styleUrl>#icon-1753-F9A825-labelson</styleUrl>"
End If

If Cells(Sor, 9) = "nem védett" Then
Print #1, "        <styleUrl>#icon-1753-0288D1-nodesc</styleUrl>"
End If

Print #1, "        <ExtendedData>"

Oszlop = 1
Do Until Cells(1, Oszlop) = "STOP"
Print #1, "          <Data name='" & Cells(1, Oszlop) & "' > """
Print #1, "            <value>" & Cells(Sor, Oszlop) & "</value>"
Print #1, "          </Data>"

Oszlop = Oszlop + 1
Loop
Print #1, "        </ExtendedData>"
Print #1, "        <Point>"
Print #1, "          <coordinates>"
Print #1, "           " & Cells(Sor, 6) & "," & Cells(Sor, 5) & "," & "0"
Print #1, "          </coordinates>"
Print #1, "        </Point>"
Print #1, "      </Placemark>"
        
Sor = Sor + 1
Loop
Print #1, "    </Folder>"

Print #1, "    <Folder>"
Print #1, "      <name>" & "Területek" & "</name>"
Print #1, "<Placemark>"
Print #1, "         <styleUrl>#poly-CCCCCC-5000-0</styleUrl>"
 Print #1, "       <name>Veszprém</name>"
 Print #1, "       <description><![CDATA[Terület:127.9 km<sup>2</sup>]]></description>"
 Print #1, " <MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>17.821106850767883,47.181342259575736 17.827259052822701,"
 Print #1, " 47.181029770408522 17.83731928568956,47.180752082125657 17.843462324928481,47.18043867361849 17.845697962176072,"
 Print #1, " 47.180462180847144 17.846269919517468,47.180090093777835 17.854094155810621,47.179787366601374 17.859674220860988,"
 Print #1, " 47.179845372144023 17.861354789094516,47.179484698757683 17.861918212440717,47.179490499347871 17.865262550411963,"
 Print #1, " 47.179524997581652 17.866969169788735,47.17839588622757 17.869767511730295,47.178046560249278 17.870893819433526,47.177673906702736 17.87144807996383,"
 Print #1, " 47.177679585368899 17.871505302647424,47.177688072836553 17.874229623409576,47.178092294544989 17.875305445793835,47.180006199811871 17.875288826961082,47.180768384446246 17.874692615107008,47.182665158853801 17.874667282615999,47.183811579773057 17.874617156623142,47.186092014990507 17.874003247957976,47.188372779584228 17.873961386465737,47.190275264847152 17.873911080809822,47.192561893028845 17.87502921384397,47.192573308219522 17.876163965710866,47.191822464243685 17.877845701754268,47.191839678834306 17.879518185150243,"
 Print #1, " 47.191856710285492 17.880619609520103,47.192630262048624 17.882284008078518,47.193025274544631 17.883393696948993,"
 Print #1, " 47.193420894528657 17.885066270176495,47.193437803386807 17.887302446413251,47.19346051130335 17.888917168136459,47.196141991544728 17.889447802974786,"
 Print #1, " 47.197665886534807 17.890557671508319,47.198061410885281 17.89216448805702,47.201120887443011 17.89270257891221,47.20188868912112 17.893787923438484,47.203424259142153 17.895975051660731,47.205733389587209 17.898766476574604,47.205761401732445 17.899330169415389,47.205767016365428 17.900448571944118,47.20577818460103 17.901557901488477,47.205789291805672 17.90212985882987,47.205410669078269 17.902684478686286,47.205416283748377 17.903810966052575,47.205049376012717 17.90437465889336,47.205054990721074 17.904383013225502,47.204670809033964 17.904937633081918,47.204676362752515 17.904945717919475,47.204298403414853 17.90550941076026,47.204304018202691 17.906072295117291,47.203925262812589 17.907206777489602,47.203180377460775 17.907761397346018,"
 Print #1, " 47.20318587030377 17.907769572015106,47.202801675080217 17.907777656852659,47.202423702385872 17.908341349693444,47.202429317372129 17.90889596954986,47.2024348102929 17.908904144218948,47.20205060963017 17.909476011728817,47.201678185617212 17.910046801260346,47.200921489116517 17.910601421116763,47.200926982193401 17.911165113957548,47.20093247526971 17.911719643982433,47.200937968345457 17.912291511492302,47.200559372026987 17.912854216186275,47.200186876510813 17.913980523889506,47.199819871570931 17.915114916430291,47.199068763907718 17.916233229127492,47.199079811480864 17.917367621668276,47.19832857126665 17.91848575470242,47.198339618993913 17.920824159218512,47.198133190914284 17.922403127993412,47.197993781313336 17.922957658018298,47.197999274693331 17.924107860908084,47.196491991966461 17.924678470776556,47.195735160458824 17.925828673666345,47.194221709227712 17.926408356519186,47.193464967425612"
 Print #1, " 17.92924712264853,47.191205604394739 17.930365165851146,47.191216470468952 17.933187492810795,47.189725416739876 17.933766007853766,47.188584373697836 17.934891866399354,47.188217166410169 17.935471279757611,"
 Print #1, " 47.187460461086928 17.937731081686344,47.186341897162606 17.940553049319874,47.184844418065836 17.942803508769654,47.183725676906676 17.94507876172127,47.18183846514826 17.946212255946769,47.181093208666866 17.947361560521273,47.179579462004227 17.949652174664248,47.176936285548067 17.951355560105998,47.175427916085169 17.954207980627661,47.172405613657901 17.954779129485306,47.172032981590739 17.957028690619797,47.170913909396482 17.958740789719798,47.169405491009861 17.959302865593074,47.16902648652237 17.961569045560321,47.167529374035432 17.963858402061899,47.164885903144402 17.965006808321117,47.163371999832506 17.966732471981913,47.16072306913648 17.96687126169331,47.160583500193482 17.96958318570454,47.157700479659461 17.970731412300697,47.156186493757623 17.972996604121136,47.154689202656947"
 Print #1, " 17.976415951418609,47.150909410233048 17.979289751844032,47.147130570897382 17.980241786382145,47.146163900485007 17.981560782713817,47.144864592486485 17.982708290657751,47.143350485293944 17.983863254618544,47.141458416960425 17.985572209615054,"
 Print #1, " 47.139571414086639 17.988437206550696,47.136170399200672 17.990145802221093,47.134283391982002 17.992424828096905,47.132017171532148 17.991869309925203,47.131633989045227 17.990774982246087,47.130483508291945 17.990782617926005,47.130099275789661 17.9902362625702,47.12971620171669 17.989134568705758,47.128943566897661 17.989157296082446,47.127797183988385 17.990319266902453,47.125526958773939 17.994285598376425,47.119197760503333 17.994350995729111,47.119087118448377 17.992718217868696,47.117169184388239 17.992732950239358,47.116405475894119 17.993317124668618,47.114887562786421 17.991926173282689,47.112520008739068 17.990620921174859,47.110294679681019 17.990088310042907,47.108765097925911 17.98992751160705,47.108426686239092 17.989026321714022,47.106474372581467"
 Print #1, " 17.987955260400764,47.1041773118232 17.987438100291698,47.101885410674171 17.988599532122539,47.099615180487788 17.989192330378525,47.098095993513788 17.990314505831449,47.09734399735185 17.988113902879938,47.096183173773916 17.988174359498561,47.093134163764205 17.988742993073409,47.092377082495702 17.988234816117181,"
 Print #1, " 47.090091462307882 17.987695018462958,47.088939777392852 17.987710020328201,47.088183798610622 17.988295182904277,47.087042470510433 17.988340368163065,47.084762004148551 17.988901455889529,47.084382885425356 17.98835554969137,47.08399978804713 17.986154228087631,47.082454708724597 17.98561595756939,47.081687260056626 17.985083795595077,47.080157590431661 17.984371251911714,47.080193988343431 17.984130862741683,47.080206284102971 17.966111017468361,47.081126561652916 17.957031295734122,47.082214369899482 17.954377852047887,47.082533801921137 17.951577264318118,47.083269369142009 17.951022554630175,47.082886019076753 17.949899031704327,47.083253281585016 17.947676509859885,47.083231994620022"
 Print #1, " 17.947106079654471,47.08361081568863 17.945998187414567,47.083215784712799 17.943775665570126,47.08319437539383 17.94323676623118,47.082048658431326 17.942715024714165,47.080518876837537 17.942785811958554,47.077092001776265 17.942809347818997,47.075951781941612 17.943394151068961,47.074432592893956 17.942880314726445,47.072524796690793 17.942349500225056,47.070994864017699 17.941811948359042,47.070227311467349 17.941273318514682,47.069081682778972 17.939628143903345,47.067925260550723 17.938520700821083,47.067530296840836 17.937999049135591,47.066000404363209 17.938567952205027,47.065249790737816 17.938575947211056,47.064865515548625 17.938038575008093,47.064097997114061 17.937484314477796,47.063714509116224 17.936946852443306,47.062946912917219 17.93584740436707,"
 Print #1, " 47.062173798239833 17.934731966278779,47.06216296696676 17.931402899667361,47.0617524784534 17.931506295756563,47.056801094258851 17.932683987094045,47.053384873555288 17.932731687635631,47.051098192561909 17.933341284387435,47.048823165642574"
 Print #1, " 17.930558123974176,47.048795988862118 17.92667578497927,47.047995675437029 17.925568791054644,47.047600502865379 17.925006715181375,47.047594993933373 17.923337914878065,47.047576875664092 17.922784462831519,47.047195105160483 17.922231549774143,"
 Print #1, " 47.047189718608259 17.919456564029968,47.046778074229486 17.91667349344824,47.046750590350399 17.91556640969209,47.046361468520494 17.915558414686064,47.046739572310258 17.915004423650345,47.04635595946052 17.914996428644319,47.046734002077997 17.914443425755412,47.046728493056499 17.913328257161709,47.046717475011789 17.912775254272802,47.046711965988585 17.912213268231056,47.046706395753439 17.909991195544261,47.046306194259671 17.908885279597982,47.046295176127735 17.906606433385225,47.048559660464562 17.906279716116391,47.049191764662133 17.906020013167755,47.049694284296535 17.904872325560763,47.051207690589244 17.903741795775698,47.052336872057765 17.902602193006263,47.053465968415111 17.901462500405298,47.054601161099747 17.900339067310981,47.054968067736525"
 Print #1, " 17.899768726937094,47.05534660012809 17.89976055226801,47.055724701425461 17.899727853591667,47.057249074866029 17.899719768754107,47.057627101474992 17.89912580268825,47.059523987150122 17.898548006297503,47.060664864432802 17.899093014180377,47.061048496757692 17.897936702746659,47.062939814558959 17.897928528077575,47.063323981244928 17.898474254612676,47.064091877971876 17.898457905274508,47.064854072916923 17.89843338126725,"
 Print #1, " 47.065994285439402 17.898970214481039,47.066762082513534 17.89726871550139,47.06826980357512 17.896112224404611,"
 Print #1, " 47.070160987555553 17.894972082646007,47.071290012410593 17.89384011555649,47.072040969255795 17.891030993831517,47.073153190688053 17.888722682877443,47.074575079886394 17.887642997737462,47.075021809927961 17.885965663438956,47.075389065468642 17.884825162354232,47.07651797957061 17.883131299054501,47.077647359163031 17.880296755006988,47.079899500996135 17.878006949347768,47.082541387032038 17.874762324373055,47.084330097302654 17.874617875275373,47.084409677059725 17.870683344162458,"
 Print #1, " 47.085894083819859 17.868451659502117,47.085871085250311 17.865658078631565,47.086226583306328 17.866757077550155,47.087000266590906 17.864259581397246,47.088655063342415 17.862796944451642,47.089624675119424 17.861110716831824,47.090369563264879 17.859978031090076,47.091114074030244 17.858853520017412,47.091486661890016 17.856680046187488,47.092715290418759 17.850948345517164,47.095972495830253 17.849278287572456,47.095577006130277 17.84861119864247,47.095404670284204 17.847969532035023,47.095393111898417 17.846376908867807,47.095560616513843 17.844657982571643,47.096246896807791 17.83898224694352,47.098827615595631 17.83797029477596,47.099051368619769 17.837344348685985,47.09999260088815 17.836914055664892,"
 Print #1, " 47.100274808334369 17.836167465832261,47.100765595012845 17.83581290078962,47.101222378449627 17.835385751872021,47.101759995915671 17.834235459150705,47.103575209682326 17.833912963963709,47.104494594348857 17.833429400846263,47.106071195696934 17.832867055478403,47.106449487472432 17.832170501807099,"
 Print #1, " 47.110223086599923 17.832771923889819,47.110632406973274 17.833325555599423,47.110638215081387 17.833334179426146,47.110260197628364 17.833896884120119,47.110266189192309 17.833888260293392,47.110644206602771 17.835004147539326,47.11027786662622 17.835566852233296,47.110283919326562 17.836120483942899,47.110289666334332 17.836111860116173,47.11066768357805 17.836683188636876,47.110295719033324 17.837236910178003,"
 Print #1, " 47.110301466039814 17.837228286351277,47.110679483199732 17.837799614871976,47.110307518737478 17.837790991045249,47.110685474716476 17.83834471258638,47.110691282818799 17.838353156750053,47.11031326574269 17.838915861444026,47.110319318439011 17.838907417280353,47.110697274334214 17.839469582985156,47.110325065442943 17.84002321469476,47.110330873584608 17.840014680699561,47.110708890535655 17.84058591938873,47.110336865140596 17.840594633046987,47.109952670532394 17.841139551098333,47.110342673280961 17.84057738539353,47.110714882049081 17.841693811628634,47.110726559384553 17.84168509797038,"
 Print #1, " 47.11111080954386 17.841271783108155,47.111300274114349 17.841113769449681,47.111482890666082 17.841676474143654,47.111488759818386 17.841667850316924,47.111873065611348 17.842221482026527,47.111878873584068 17.842784276552024,47.111884803829241 17.843883095807563,47.112274364467012 17.844445800501536,47.112280416940294 17.844999522042666,47.112286163732485 17.845562226736636,47.112292093932275 17.84611585844624,47.112297901859272 17.846124392441443,47.111919896194394 17.846687097135412,47.111925765298501 17.846695720962142,"
 Print #1, " 47.111541582159958 17.847249352671746,47.111547390168859 17.847232284681347,47.112309578847409 17.84898390965385,47.111734407716511 17.84948220514195,47.111570805608814 17.850598631377057,47.111582360482707 17.851723411944299,47.111216088100946 17.853402003884209,47.110849262958872 17.853853407314478,47.115428404532366 17.857084018570756,47.120792508741687 17.858183556478515,47.121566301090709 17.860391345952298,47.122729688534648 17.861482709190973,47.123881498337227 17.863110815811915,"
 Print #1, " 47.125807380594367 17.863613962202546,47.128093606739014 17.864109293250213,47.13114819279761 17.864637861963388,47.132294197916835 17.865729494696648,47.133445861736924 17.866249619246158,47.134976017390969 17.866770462447889,47.136884265557789 17.867488126528372,47.13790188436387 17.86785365101748,47.138420188456294 17.866711532965251,47.139548866435426 17.866106158295281,"
 Print #1, " 47.141451817883073 17.863779970867053,47.145995883040499 17.863182950529229,47.147514497057102 17.862595272670358,47.149026958301896 17.861998252332533,47.150545607906174 17.860797025134609,47.154723167216297 17.858468951244284,47.15888897570904 17.857880285238597,47.160023388318429 17.857300602385759,47.161164067938522 17.855031817304187,47.162659099933215 17.852779830718429,47.163398018787696 17.851073929993884,47.164904958738795 17.848821763745068,47.165643907430017 17.846570226316953,47.166760769870677 17.845998179144022,47.167139118721849 17.845435474450049,47.167511296544326 17.843183128538175,47.16824996469208 17.840350650615818,"
 Print #1, " 47.170123063803366 17.838098214872417,47.170861695629668 17.83698053099592,47.170849970425841 17.835871470946142,47.170460105925002 17.834173655059153,47.171582668553597 17.834156317574173,47.172344913037286 17.833592984059504,47.172338867398231 17.833030099702473,47.172711008786074 17.832466945850857,47.173089376319126 17.831886274851204,47.173845614775381 17.830751253489719,47.174589812762164 17.828489654930419,47.175712410227888 17.826254646503529,47.176066697647499 17.825136962627028,47.176054790404464 17.824001671770958,47.176805063625046 17.823984244454447,47.177567294212366 17.823394859796537,47.179085799809414"
 Print #1, " 17.821106850767883,47.181342259575736</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"


 Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 1</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
 Print #1, "17.9637024792849,47.0923734323346 17.9706605336621,47.080629634821 17.9702605456903,47.0806449194864 17.9666145904468,47.0808430586229 17.9656019214706,47.080869643729 17.9595432075259,"
 Print #1, "     47.0816842555451 17.9581631455406,47.0818478297205 17.9581630280495,47.0818478436456 17.9581989833163,47.0818909621879 17.95819911399,47.0818909686534 17.9599789974308,47.0820512256694 17.9589574128286,47.0831585957498 17.9577138656195,"
 Print #1, "     47.0852837730501 17.9582080758334,47.0854503303381 17.9550120814801,47.0901101505822 17.9552714219338,47.0902079013848 17.9549428437708,47.0907249385167 17.9576904591073,47.0914051178432 17.9622295434618,47.0925509945073 17.9637024792849,47.0923734323346"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 2</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
   Print #1, " 17.981638011947,47.14407623296 17.9755102939483,47.1510427269377 17.9755933936021,47.151045461349 17.9760617775416,47.1505539898867 17.9777160661892,47.1486204933374 17.9789541722519,47.1471420826005 17.9811213606571,47.1447783515205 17.981638011947,47.14407623296"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"


Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 3</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
 Print #1, "  17.9472637269217,47.1509355344517 17.9445060989407,47.1509089925445 17.9450025748673,47.1499104063223 17.9442736011485,47.1495719541064 17.944621121205,47.1493217844929 17.9404072377785,"
  Print #1, "     47.147839784438 17.9406873156535,47.1475356254199 17.9386665939391,47.1468888345903 17.9387911494692,47.1465431390929 17.9382451601838,47.1464577802423 17.9386001523826,47.145380299591 17.9379885310411,47.1451608863597 17.9378684914489,"
  Print #1, "     47.1451061038002 17.9365678790516,47.1471325268474 17.9363086682667,47.148255913499 17.9359097585122,47.1504236873054 17.9364789916461,47.1513943506403 17.9377555032094,47.1523718704521 17.9367269704857,47.1564637201683 17.9359676348799,"
  Print #1, "     47.1589496151878 17.9352197210024,47.1608726204439 17.9349489175938,47.1625589746777 17.9338659688094,47.1635940077554 17.9333539882676,47.1655192952879 17.9389255421643,47.1641256797862 17.9409266722135,47.1643058952596 17.9408798835547,"
  Print #1, "     47.1665574200171 17.9385935521533,47.1696419322159 17.9384530649629,47.1698314748793 17.9384213136592,47.1698611252985 17.9364082413784,47.1717419155061 17.937271513452,47.1724027972676 17.9378232710192,47.1717556379428 17.9386386593537,"
  Print #1, "     47.1722460134928 17.941611351215,47.1698919814622 17.9418868509284,47.169673780889 17.9435550893215,47.1683525656459 17.9487863497051,47.1663118585346 17.9469845883357,47.1621927416072 17.9520206795103,47.15813923318 17.9512269034125,"
   Print #1, "    47.1566035073081 17.9513778883398,47.1549963984435 17.9498637785281,47.1540971834182 17.9475160044,47.1535920782086 17.9472637269217,47.1509355344517  "
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"


Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 4</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9921227663707,47.1218602769103 17.9859036309943,47.1182112682951 17.9836837128267,47.1181906430178 17.9825572173471,47.1181801602729 17.9781178613919,47.1155534430383 17.9779912821769,"
Print #1, "      47.1130871520943 17.9726578900873,47.1067841855584 17.9678508007781,47.1049953020346 17.9681040023105,47.1038586524941 17.963462727285,47.1030133437222 17.9589338164734,47.1104422360992 17.9624497614851,47.1107763090035 17.9656770595128,"
Print #1, "      47.1123099173384 17.9636935615016,47.114575873555 17.9600916631583,47.1141208318674 17.9593785596963,47.1145349034403 17.9565799961398,47.1178752542267 17.959914109105,47.1185082366482 17.9590908254551,47.1200035302999 17.9599604275899,"
Print #1, "      47.1205528469381 17.9622441541368,47.1208751973382 17.9642733404854,47.1207140528987 17.9709044035383,47.1238430830154 17.9776776492963,47.1243273894388 17.9764023878335,47.1264198038201 17.9765264366451,47.126465137516 17.9747586975406,"
Print #1, "      47.1262544323985 17.9717439846489,47.1258951452699 17.9715269822529,47.1258317489625 17.9710417433068,47.1257682575358 17.9591478018034,47.1258360986632 17.9590390271755,47.1268571476947 17.9614769083435,47.1282631564395 17.9682492773281,"
Print #1, "      47.1288082832299 17.9690298593155,47.1294168740655 17.9674140155716,47.1309047501785 17.9675300718885,47.1312860338213 17.9675791356891,47.1314474426198 17.9677071529631,47.1314207620516 17.9808496501037,47.1286859836016 17.9822540461359,"
Print #1, "      47.1285546770427 17.9916344626752,47.131975778874 17.9916466104959,47.1319605104749 17.9917425842109,47.1318672042059 17.9913755715446,47.1316479940248 17.990599712958,47.1303881749461 17.9906366863385,47.1300659966496 17.9903224984177,"
Print #1, "      47.1300886434743 17.9902354408828,47.130064808265 17.9901786520034,47.1299704512943 17.9898525702611,47.1297754546409 17.9898532969052,47.1297388461255 17.9895893165378,47.1295632252091 17.9894595072861,47.1294220412119 17.989460319924,"
Print #1, "      47.1293811152307 17.9891681684123,47.1291174281575 17.988732716583,47.1286753655228 17.9887440126291,47.1275230342949 17.9901560947247,47.1255469063762 17.9921227663707,47.1218602769103"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 5</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9031795224675,47.2050227966044 17.903224328583,47.205002088945 17.9065637027102,47.2030626852548 17.9065964502608,47.2029835984442 17.9067062055766,47.2029623803051 17.906728600923,"
Print #1, "      47.2029669113509 17.907222825359,47.2026798592419 17.9072197147497,47.2026416431605 17.9073158660562,47.2025960887734 17.9073608916195,47.20259966759 17.9075440713136,47.2024932725201 17.9075708558764,47.2024501857635 17.9075659670474,"
Print #1, "      47.2023887817767 17.9076084796213,47.2023453023984 17.9077335752446,47.2023720067183 17.9079037037607,47.2022437013174 17.9078750463542,47.2021518330683 17.9079514395589,47.2021227249332 17.9080548893682,47.2021965735911 17.9083013924548,"
Print #1, "      47.2020533949702 17.9084553363708,47.201849477623 17.9085674104408,47.201787617125 17.9087372927694,47.2017261511984 17.9088852813117,47.2016576301857 17.9089407815581,47.2015376302072 17.9091481694438,47.2014197692188 17.9093164180942,"
Print #1, "      47.201267962522 17.9094368576693,47.2011913402644 17.909534914073,47.2010750014326 17.9096461785099,47.2010261766145 17.9098406124591,47.2008904628643 17.9099851258849,47.200873185336 17.9101118194375,47.2008003129944 17.9102148158267,"
Print #1, "      47.2007924290567 17.910432267699,47.2008457768934 17.9105230023723,47.2008499353069 17.9105684404245,47.2008404763585 17.9106622437497,47.2007454104511 17.9110283660775,47.2006424357762 17.9114351087147,47.2006152524331 17.9115841340343,"
Print #1, "      47.2005349530095 17.9116247942533,47.2004914538078 17.9118286987454,47.2004497528596 17.9118294946761,47.2002701929787 17.9122319227118,47.2000243520106 17.9123878285406,47.1998874425425 17.9127612103703,47.1998026170632 17.9128466687578,"
Print #1, "      47.1997442673025 17.9129732492305,47.1996949612463 17.9131009222416,47.1997058516552 17.9133144165414,47.1996165622433 17.9134865012301,47.1995130980877 17.9136858719491,47.1993679805985 17.9138344221558,47.1993282472702 17.9139270425217,"
Print #1, "      47.1992867908202 17.9140757227771,47.1991789558763 17.9143055528007,47.1990785807901 17.9144065671028,47.1990210135047 17.9146879959859,47.1989645105461 17.9155490938019,47.1988794597258 17.9159447697544,47.1987636268367 17.916815992989,"
Print #1, "      47.1984502485746 17.9171687170575,47.1983491014887 17.9182232649964,47.1981414294523 17.9187458266541,47.1980986119914 17.9188418226986,47.1980626957502 17.9195473233951,47.1978572399414 17.9214281638772,47.1978757433898 17.9217759212271,"
Print #1, "      47.1978388511649 17.9226057344978,47.1978711126966 17.9234914697987,47.1962993256916 17.9242882682756,47.1954120024151 17.9253774200915,47.1938844774372 17.9261003350214,47.1931618612715 17.9277955778535,47.1918843172016 17.9287576575537,"
Print #1, "      47.1912204294995 17.9296960024897,47.1910634275293 17.9325163664598,47.189372430657 17.9333627322077,47.1885574091004 17.9344103064167,47.1878567025082 17.9351976944286,47.1871522895792 17.936150506711,47.1866203176111 17.9371643635362,"
Print #1, "      47.1860077824685 17.9403479071327,47.1846335498793 17.9423335382497,47.1835573312416 17.9431628644989,47.1829921731576 17.9442729710819,47.1821595536907 17.944818826611,47.1817789569501 17.9455115988726,47.1808471251469 17.9469453058856,"
Print #1, "      47.1795286416512 17.9479636187101,47.1781638708081 17.9485113670631,47.1773687227499 17.9491346418781,47.176627555034 17.9506519936257,47.1752801403968 17.9514024818008,47.1745220964032 17.9520853839,47.1737968675029 17.9527434096412,"
Print #1, "      47.1730678881923 17.9535477704573,47.1722789481969 17.9546257855113,47.1718082972711 17.9554726853311,47.1712586034039 17.9564611624836,47.1706811943309 17.9572745314597,47.1700083684688 17.9582090314145,47.1693331799724 17.9591342938794,"
Print #1, "      47.1688505981679 17.9602292080155,47.1680826364602 17.9609903800406,47.1674616469205 17.9615617214297,47.166801247226 17.96224241491,47.1659914622886 17.962925884611,47.1652386466277 17.9632881929497,47.1647292860489 17.9647582265559,"
Print #1, "      47.1632613187411 17.9653726834292,47.1624414429069 17.9659019021914,47.1616610622007 17.9665240974623,47.1607180941539 17.9682438320306,47.1585231957726 17.9692397705881,47.1573501900155 17.970469943848,47.1561553597226 17.9715368864022,"
Print #1, "      47.1552886088287 17.97240832175,47.1545274285442 17.9723571606381,47.1544224102865 17.9741810524052,47.1525273527952 17.9755933936021,47.151045461349 17.9755102939483,47.1510427269377 17.981638011947,47.14407623296 17.9822569239845,"
Print #1, "      47.1432351166085 17.9740042945093,47.1438705606897 17.9730614284744,47.1438617120693 17.9693029876663,47.143182941389 17.9661224902044,47.143072593269 17.9630597337811,47.1429630926203 17.9609416060672,47.1427821452141 17.9608779011519,"
Print #1, "      47.1428735734635 17.9540191787536,47.1526892574108 17.9479767361723,47.150771454602 17.9472254892723,47.1505330275095 17.9472637269217,47.1509355344517 17.9475160044,47.1535920782086 17.9498637785281,47.1540971834182 17.9513778883398,"
Print #1, "      47.1549963984435 17.9512269034125,47.1566035073081 17.9520206795103,47.15813923318 17.9469845883357,47.1621927416072 17.9487863497051,47.1663118585346 17.9435550893215,47.1683525656459 17.9418868509284,47.169673780889 17.941611351215,"
Print #1, "      47.1698919814622 17.9386386593537,47.1722460134928 17.9378232710192,47.1717556379428 17.937271513452,47.1724027972676 17.9364082413784,47.1717419155061 17.9384213136592,47.1698611252985 17.9384530649629,47.1698314748793 17.9385935521533,"
Print #1, "      47.1696419322159 17.9408798835547,47.1665574200171 17.9409266722135,47.1643058952596 17.9389255421643,47.1641256797862 17.9333539882676,47.1655192952879 17.9338659688094,47.1635940077554 17.9349489175938,47.1625589746777 17.9352197210024,"
Print #1, "      47.1608726204439 17.9359676348799,47.1589496151878 17.9367269704857,47.1564637201683 17.9377555032094,47.1523718704521 17.9364789916461,47.1513943506403 17.9359097585122,47.1504236873054 17.9363086682667,47.148255913499 17.9365678790516,"
Print #1, "      47.1471325268474 17.9378684914489,47.1451061038002 17.9370003787461,47.1447109267089 17.9374971353846,47.1443420341704 17.9382808854929,47.1444634381924 17.9394919700992,47.1425764735442 17.9403454962396,47.1412173667663 17.9406024696582,"
Print #1, "      47.1394851603694 17.9411119839045,47.1396348404465 17.939419650298,47.1385033569467 17.9394222651597,47.1385931667234 17.9366445332729,47.1378035161702 17.936669681368,47.1365973370246 17.941476822191,47.1321398352407 17.9428881342316,"
Print #1, "      47.1318179920759 17.9435386914147,47.1311824648395 17.9437899743026,47.1312005429995 17.9440853841828,47.1307428644738 17.9443427333071,47.1306206554388 17.9387074267919,47.129298130684 17.936320738764,47.1307226850087 17.9338513845538,"
Print #1, "      47.1304573907013 17.9285390077434,47.13088812887 17.9198876361848,47.1275860482479 17.9188341902752,47.1272539459651 17.9164538900031,47.1283564395566 17.914155270192,47.1311486951914 17.9111666802224,47.1331297691294 17.9155966488547,"
Print #1, "      47.1354256787983 17.9163890838226,47.1369616570895 17.916356648219,47.13848947817 17.9062080723021,47.1390321390657 17.9013677362961,47.1393859052571 17.8975914327256,47.1395893969596 17.8929439399043,47.1384800233244 17.8926662591966,"
Print #1, "      47.1384137059449 17.8921821984699,47.1390060086441 17.883278222373,47.1392678024837 17.8815319955792,47.1398414557817 17.8784986798718,47.1398105097686 17.8671758191601,47.1384423199865 17.8664417895194,47.1395457343137 17.8657601454165,"
Print #1, "      47.1412213238687 17.8646554371795,47.1435155481791 17.8634686546525,47.1459265886688 17.862530601397,47.1474011320687 17.862265243664,47.148813452355 17.8617409755456,47.150457899887 17.8610745898253,47.1523059023599 17.8602461135968,"
Print #1, "      47.1544123108353 17.8579693051178,47.1585900612934 17.8573452523152,47.1599321571112 17.8569597726392,47.1605547573341 17.8566142540223,47.1610769216324 17.8558355421033,47.1615584105716 17.8544133636089,47.1623998895838 17.8523483716604,"
Print #1, "      47.163381556368 17.8507185238147,47.1645665596355 17.8485395464606,47.1654363998807 17.8472794154747,47.1661368935157 17.8462418831409,47.1666405255316 17.8453595683859,47.1668708434391 17.8448297185586,47.1671834872745 17.8428272273564,"
Print #1, "      47.1680161191587 17.8418426191046,47.1687307882154 17.8397882918488,47.170122586968 17.8373959672936,47.1707952827867 17.8365190110145,47.1704835473666 17.8351713970666,47.1703958755324 17.8339627172826,47.1714944181191 17.8334673413761,"
Print #1, "      47.1720838401447 17.8329792219887,47.1722852252175 17.832794934198,47.1725098939658 17.8320981063929,47.1729360445931 17.8314074001419,47.1735442566181 17.8301461553249,47.1744366301189 17.8293018919824,47.1749441450468 17.8282641489622,"
Print #1, "      47.1754937672719 17.8282010216681,47.1755309707112 17.8258370722328,47.1757664074742 17.8248299729034,47.1759790444212 17.823788016502,47.1766229558122 17.8234464265005,47.1774433015141 17.8231514263549,47.1788364153673 17.8210435778644,"
Print #1, "      47.1808426628916 17.8212872985323,47.1811105180213 17.8270892752069,47.18077609098 17.829093190007,47.1807089008297 17.8344154387815,47.1804731896648 17.8355164839704,47.1804481407747 17.8367795673073,47.1803939362594 17.8378823292559,"
Print #1, "      47.1803396440595 17.8400586284162,47.1802742630507 17.8429727419585,47.1801642432408 17.8449952426464,47.1801891855017 17.8456642851894,47.1800815925646 17.8535450109785,47.179763496808 17.8560056632657,47.1797252481433 17.8594350940935,"
Print #1, "      47.1796331256172 17.8606396099379,47.1794101763102 17.8617282891521,47.1794112875658 17.8647002010207,47.1791657376163 17.8666704596895,47.1781653281728 17.8691883739899,47.1779085031704 17.8705149094335,47.177593592598 17.8711981718141,"
Print #1, "      47.1775908966818 17.8738802633577,47.1779464267199 17.8748782784425,47.1798818962557 17.8747010769049,47.1805105549788 17.8746194050215,47.1814326672472 17.8744535862599,47.1825145045848 17.8741222395469,47.1837420980257 17.8740517517365,"
Print #1, "      47.1847907244962 17.8741111367581,47.1858442799096 17.8739362056186,47.187045045772 17.8737282627519,47.1881146633583 17.873628641122,47.1892031145239 17.8735594609201,47.1902814415072 17.8733458800534,47.191356904482 17.87325271854,"
Print #1, "      47.1923325550715 17.8734953480632,47.1923837435906 17.8743237128259,47.1922161334628 17.8754883453727,47.1915367674135 17.8773046700389,47.1916667129585 17.878859885065,47.1916914065177 17.8803037791851,47.1924171175699 17.8816531351224,"
Print #1, "      47.192971725043 17.88264180716,47.193218929238 17.8831847879867,47.1933452716497 17.8847268691372,47.1933270185242 17.8859710862845,47.1931929094602 17.8869758409906,47.1931151978887 17.8874668863337,47.1940322301439 17.888255495121,"
Print #1, "      47.1953226545848 17.8886250698701,47.195970718109 17.8887734111869,47.1973293287159 17.8898759714434,47.1980499332455 17.8910036433801,47.1995721812344 17.8918683183878,47.2007836373498 17.8922686463823,47.2016301887809 17.8930360785165,"
Print #1, "      47.2027084971938 17.8930381201595,47.2027118228939 17.8940279764117,47.2039220555932 17.8943884719626,47.2042425100525 17.8967167416212,47.20511275495 17.8968748052749,47.2051716494571 17.9031795224675,47.2050227966044"
Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 6</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.919915904965,47.0465855620121 17.9194331818808,47.0464914461681 17.9179873574071,47.0464217963954 17.9174324421892,47.0464091579356 17.9168106732011,"
 Print #1, "      47.0464176359946 17.915854050619,47.0464950051187 17.9149494636679,47.046431700637 17.9149307429093,47.0465696130298 17.9147805705669,47.0465817988773 17.9147185891451,47.0473750453149 17.9140125995358,47.0484274833431 17.9143937241674,"
 Print #1, "     47.0485355350683 17.9143194531838,47.048710772057 17.9148270486285,47.0487206642367 17.9147974431149,47.0505124951113 17.9149935594815,47.0506990498239 17.9149602685252,47.0512319486604 17.9150810238668,47.0513908562058 17.9159376773095,"
 Print #1, "     47.0517694647979 17.9174997011315,47.0522876558094 17.918413939476,47.0523351104581 17.9191030423677,47.0524718297237 17.9192671189738,47.052331933722 17.9201330256381,47.0518695999731 17.9212207745351,47.0509241707052 17.9222710021152,"
 Print #1, "     47.0494216524072 17.923430241648,47.0475024854615 17.9231635341866,47.0474733207525 17.9232315657296,47.0473765198729 17.9229492132865,47.047346347321 17.9227992139019,47.0472912065663 17.9217308035869,47.0470882803497 17.9206349065494,"
 Print #1, "     47.0467783578258 17.919915904965,47.0465855620121"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 7</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.8964722880951,47.0713275419948 17.8979779200855,47.0704230626235 17.89967705405,47.0709695008025 17.899752371146,47.070112790768 17.9011016951567,47.0699153636231 17.9021035618994,"
Print #1, "      47.0697893805094 17.9021762607634,47.0697580812023 17.9023528666826,47.0697322314089 17.9024989461438,47.0696194382277 17.9034158299511,47.0692253032177 17.9038441578768,47.0683597091048 17.9045848420857,47.0674427183653 17.9061887864315,"
Print #1, "      47.0676796149646 17.9062196569184,47.0676522137448 17.9064133592094,47.0676946327492 17.9072840072723,47.066707039814 17.907356751914,47.066642450317 17.9093512492258,47.0648285561177 17.909638406447,47.0623653582999 17.9086255623824,"
Print #1, "      47.0597192631392 17.9058462653436,47.0584766249065 17.9058534353879,47.0583568616806 17.9066477073714,47.0567786925317 17.90840746558,47.054475034819 17.9106563613335,47.0550997576026 17.9123930854021,47.0556567318773 17.9134334021886,"
Print #1, "      47.0532368101008 17.9121204815161,47.0532735211123 17.9104262082197,47.0531373758676 17.9101795376982,47.0507649427356 17.9100686925304,47.0498762330857 17.9106125603589,47.0487276509078 17.9101843320452,47.046710484886 17.9104474236207,"
Print #1, "      47.0465011435941 17.9093399331087,47.0461949352454 17.9090506994432,47.0460832887723 17.90836943879,47.0459849156739 17.9075352672614,47.0468405400514 17.9067132878115,47.0477649245028 17.9060544375298,47.0485380806363 17.9054713522078,"
Print #1, "      47.0495710932963 17.9043660331823,47.0509992284129 17.9032592341585,47.0520638746861 17.9027599455108,47.0526226014058 17.9023597251479,47.0532139862612 17.900766124503,47.0543421929224 17.8996424831368,47.0546471408003 17.8993742563104,"
Print #1, "      47.0551035435541 17.8992642833866,47.0554363931707 17.8992738646107,47.0561229320537 17.8991750369427,47.0570633457014 17.8990197030881,47.0573810746353 17.898652163976,47.0593431419589 17.8982576581096,47.0603860216802 17.8984140834764,"
Print #1, "      47.0609535723148 17.8982086386267,47.0613477172833 17.8974389918379,47.0625688210854 17.8977344687586,47.0631109619574 17.8977872891573,47.0639224485971 17.898108962279,47.0648564745453 17.8980021368152,47.0655229168997 17.8980368523272,"
Print #1, "     47.0656528421604 17.8979825591653,47.0657958415839 17.8985554136816,47.0667650975455 17.8970812456694,47.0680841946888 17.8956654573531,47.0700807669017 17.8945722444325,47.0710875295888 17.8939852123653,47.0715018379225 17.893280056501,"
Print #1, "     47.0719037946156 17.8932545999761,47.0719154591895 17.8935882494141,47.0720631715813 17.8943311627158,47.0725217600868 17.8949584717443,47.0721818082804 17.8951324617948,47.0721069116176 17.8962471616631,47.0715389439268 17.8964722880951,"
Print #1, "     47.0713275419948"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 8</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9332787588448,47.0820194398383 17.9329756622641,47.0812399041212 17.9344867816476,47.0801440961462 17.9335841508283,47.0803246803578 17.9320892358857,47.080997167772 17.9299748163503,"
Print #1, "      47.0818924529482 17.9279711960545,47.0815027291782 17.9269796383837,47.082346875414 17.9278210782328,47.0831577920485 17.9282471175933,47.0831784280325 17.9291197345316,47.0839613008598 17.9309328267754,47.0833841742323 17.9320301176508,"
Print #1, "      47.0830367351794 17.9314197184788,47.0830208808677 17.9316920334671,47.0827529235834 17.9332787588448,47.0820194398383"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 9</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9372650859062,47.0926681824209 17.9374752544758,47.0924566459642 17.9375590530179,47.0926266839109 17.9379892891217,47.0922467989166 17.9388924733194,47.0915352997992 17.9402557632612,"
Print #1, "     47.0908615378571 17.9421472159238,47.0897376444903 17.9440431085311,47.0884653209328 17.9442562728872,47.0880431929994 17.9449735182246,47.0874683985141 17.945629774324,47.0859941707935 17.9453456779259,47.0858851832898 17.9455342385447,"
Print #1, "      47.0855117567856 17.9439240449,47.0853394141982 17.9437191471924,47.085260695693 17.943023933172,47.0852430949619 17.9396670414984,47.0848837683539 17.939636437934,47.084898675879 17.939228644936,47.0847914429681 17.9378133090986,"
Print #1, "      47.0856375098993 17.938769949122,47.0867463467895 17.93774368281,47.0874833696083 17.9376279554412,47.0876643356422 17.9373258200657,47.0878907231903 17.9373096277943,47.0881623507533 17.93693124227,47.0887546048774 17.9370708049222,"
Print #1, "      47.0910539405829 17.9372650859062,47.0926681824209"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 10</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9677071529631,47.1314207620516 17.9675791356891,47.1314474426198 17.9675300718885,47.1312860338213 17.9630707094818,47.1307257496175 17.9527195378266,"
Print #1, "      47.1292235449973 17.9462079112271,47.1305322864987 17.946412243706,47.1311254091947 17.9517279265288,47.1298156432532 17.9586545596245,47.1311517097143 17.9674932170524,47.132701090082 17.9677071529631,47.1314207620516"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 11</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.8822597441634,47.0885644527546 17.8773977505645,47.0938699390718 17.8767124351097,47.094591019373 17.8782535913635,47.0938962377455 17.8798002186539,"
Print #1, "      47.0933588422303 17.8802004451756,47.0926058645416 17.8805828244839,47.0926679758614 17.8803130346476,47.0933059603372 17.8812921789487,47.0933740697219 17.882478062769,47.0937355874273 17.8832815714853,47.0940349018666 17.8838173743997,"
Print #1, "      47.094884687092 17.8831945381097,47.0960721950373 17.8830036265974,47.0970020284067 17.8836773855887,47.0973873748479 17.8853819403063,47.0974338604546 17.8856415383028,47.0972617847414 17.8866634338594,47.0973304616492 17.8879786060358,"
Print #1, "      47.0976349354611 17.887757127132,47.0980111757213 17.8866361505068,47.098105600648 17.8871999009581,47.0981113225872 17.8896511537648,47.0979181827402 17.8897592869096,47.0978467651768 17.891048492689,47.0972784520231 17.890538561167,"
Print #1, "      47.0962560498239 17.8907750460659,47.0951685961862 17.8913084678684,47.0951012989715 17.8914368070257,47.0940853527802 17.8916031506802,47.0940810968228 17.8922015961794,47.0916504198896 17.8927833993251,47.0903751832975 17.8924512591404,"
Print #1, "      47.0899641927145 17.8926158692577,47.0897474184428 17.8906882761406,47.0893550216547 17.8822597441634,47.0885644527546"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 12</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.963462727285,47.1030133437222 17.9595217775578,47.1022953332198 17.9549264572519,47.1016121392153 17.9507686952557,47.109221855905 17.9514746328173,47.1134373478153 17.9508448748183,"
Print #1, "      47.1183614584133 17.9533057304778,47.1186255904268 17.9548932535114,47.1185204831497 17.9567476904226,47.1182977070474 17.9586530281493,47.1198790813875 17.9585071424566,47.1227035625927 17.9607113735518,47.1226042429593 17.9645216698709,"
Print #1, "      47.1214980136612 17.9660065905479,47.1221132933477 17.9688763361509,47.1239441703453 17.9702551169642,47.1254601928654 17.9715269822529,47.1258317489625 17.9717439846489,47.1258951452699 17.9747586975406,47.1262544323985 17.9765264366451,"
Print #1, "      47.126465137516 17.9764023878335,47.1264198038201 17.9776776492963,47.1243273894388 17.9709044035383,47.1238430830154 17.9642733404854,47.1207140528987 17.9622441541368,47.1208751973382 17.9599604275899,47.1205528469381 17.9590908254551,"
Print #1, "      47.1200035302999 17.959914109105,47.1185082366482 17.9565799961398,47.1178752542267 17.9593785596963,47.1145349034403 17.9600916631583,47.1141208318674 17.9636935615016,47.114575873555 17.9656770595128,47.1123099173384 17.9624497614851,"
Print #1, "      47.1107763090035 17.9589338164734,47.1104422360992 17.963462727285,47.1030133437222"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 13</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9757404195861,47.1067972831371 17.9735191393367,47.1057755903319 17.9716390676668,47.1049108132858 17.9702401311725,47.1044166034792 17.9686331053819,47.103958288251 17.9685840735836,"
Print #1, "      47.1039461302624 17.9681040023105,47.1038586524941 17.9678508007781,47.1049953020346 17.9726578900873,47.1067841855584 17.9779912821769,47.1130871520943 17.9781178613919,47.1155534430383 17.9825572173471,47.1181801602729 17.9836837128267,"
Print #1, "      47.1181906430178 17.9859036309943,47.1182112682951 17.9921227663707,47.1218602769103 17.9924690275397,47.1212111356424 17.9925133952913,47.1211470408068 17.9927798890772,47.120654607478 17.9928856712938,47.1204841118036 17.9937063475821,"
Print #1, "      47.1188796138874 17.9920707142478,47.1169523510995 17.9924779820055,47.1162381976557 17.9927561404601,47.114815465204 17.9905021724281,47.1101916181561 17.9821322942095,47.1130055191509 17.977377293922,47.1085721331612 17.9761760967884,"
Print #1, "      47.1069975776131 17.9757404195861,47.1067972831371"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 14</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9916344626752,47.131975778874 17.9822540461359,47.1285546770427 17.9808496501037,47.1286859836016 17.9677071529631,47.1314207620516 17.9674932170524,47.132701090082 17.9674618502067,"
Print #1, "      47.1328892686167 17.9680772179111,47.1329551718537 17.9723223881671,47.1321534410323 17.9775388515032,47.1312403599431 17.9817825413194,47.1304983628635 17.9843489453383,47.1299210124718 17.9860044252479,47.1308382713728 17.9876588987527,"
Print #1, "      47.1318155921147 17.9910933515181,47.1326665767528 17.9912730540103,47.1323972545829 17.9913993376609,47.1322713017138 17.9916344626752,47.131975778874"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 15</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.8558924209426,47.1102001175178 17.8547908793605,47.1077152830182 17.8544273930378,47.1079300199185 17.8538958210391,47.1083599103594 17.854523827063,47.1103159418523 17.8530789084478,"
Print #1, "      47.110814766832 17.8531145058749,47.1108459818607 17.8531515640151,47.1113623253978 17.85315761091,47.1119100131766 17.8532127116689,47.1126386853999 17.8533028952607,47.113354408777 17.8533531035042,47.1138286907717 17.8545369504901,"
Print #1, "      47.113044844667 17.8549988184277,47.111768092142 17.8574883979615,47.1102167340719 17.8561223185121,47.1102025124742 17.8558924209426,47.1102001175178</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.8921821984699,47.1390060086441 17.8926662591966,47.1384137059449 17.8929439399043,47.1384800233244 17.8975914327256,47.1395893969596 17.9013677362961,47.1393859052571 17.9062080723021,"
Print #1, "      47.1390321390657 17.916356648219,47.13848947817 17.9163890838226,47.1369616570895 17.9155966488547,47.1354256787983 17.9111666802224,47.1331297691294 17.914155270192,47.1311486951914 17.9164538900031,47.1283564395566 17.9188341902752,"
Print #1, "      47.1272539459651 17.9198876361848,47.1275860482479 17.9285390077434,47.13088812887 17.9338513845538,47.1304573907013 17.936320738764,47.1307226850087 17.9387074267919,47.129298130684 17.9443427333071,47.1306206554388 17.9440853841828,"
Print #1, "      47.1307428644738 17.9437899743026,47.1312005429995 17.9435386914147,47.1311824648395 17.9428881342316,47.1318179920759 17.941476822191,47.1321398352407 17.936669681368,47.1365973370246 17.9366445332729,47.1378035161702 17.9394222651597,"
Print #1, "      47.1385931667234 17.939419650298,47.1385033569467 17.9393733455342,47.1369452649532 17.9403528447506,47.1351853265566 17.9413559524839,47.1332248974568 17.9415289103506,47.1332315174703 17.9427577811026,47.133539912038 17.9445399990263,"
Print #1, "      47.1341972026733 17.9440622907506,47.1329593649028 17.9475257295779,47.1336248936155 17.9464456944307,47.1312227127238 17.946412243706,47.1311254091947 17.9462079112271,47.1305322864987 17.9445557716066,47.1257353899398 17.9376547827145,"
Print #1, "      47.1232557973888 17.9356603680148,47.1228342884082 17.9296655069148,47.1221324372639 17.9256532225551,47.1224148740342 17.9210705391801,47.121806840249 17.9196704518888,47.1211496156177 17.9186990439273,47.1225073219562 17.9167013947513,"
Print #1, "      47.1222463065285 17.9155932925482,47.1244873517808 17.9132420119044,47.124222777189 17.9123269083214,47.1229268401197 17.9104488002796,47.1225864728411 17.9078571155333,47.1225606832945 17.9071484045839,47.1226340496386 17.9064449883219,"
Print #1, "      47.122466177818 17.905266893129,47.1224544207831 17.9028899806821,47.1233958100299 17.8987112207394,47.1266381957057 17.8971580482196,47.1254096773453 17.8978037009047,47.1222616241664 17.8977606891015,47.1221230951033 17.897100806664,"
Print #1, "      47.1254173785679 17.8956788713395,47.1260727731011 17.8922494055637,47.1288041787312 17.8895028037192,47.1275827517919 17.8900246610365,47.1271221918515 17.8882096835407,47.12623025092 17.8870662380393,47.1258401738963 17.8826469368587,"
Print #1, "      47.1230873896903 17.8821741046642,47.1202135710442 17.8821054790774,47.1202296955095 17.8809073336354,47.1155842503076 17.8778494451478,47.1167359821059 17.8759313212453,47.1185893498665 17.8738925132464,47.1193570907296 17.8724682703912,"
Print #1, "      47.1184552270256 17.8709147579346,47.1168619771998 17.869602239995,47.1174399948945 17.8695913494807,47.1179328058243 17.8682962363694,47.1177222570464 17.8670120458388,47.1170189728404 17.8619982431528,47.1151926302879 17.8608410500108,"
Print #1, "      47.1152792338975 17.8543242923039,47.1160986882389 17.853394110389,47.1142658841243 17.8534313823118,47.1147018247715 17.8535469502839,47.1153965806023 17.8540993616299,47.1162877915788 17.8545741463855,47.1171798103409 17.8555397776891,"
Print #1, "      47.1187014873103 17.8560174179686,47.1196387819465 17.8565336052912,47.1204620387426 17.8576399521699,47.1212887337505 17.8597980017773,47.1226780126454 17.8611285104572,47.1237302051083 17.8616524188592,47.1246856761239 17.8623969676584,"
Print #1, "      47.1258028505893 17.862798645573,47.1267796317257 17.8631868496433,47.12775834088 17.8634784065107,47.1288335712314 17.8637023701463,47.1297535399499 17.8639345595544,47.1310513593983 17.8643828725916,47.1323058002541 17.8654119735093,"
Print #1, "      47.1333922466361 17.8655919200396,47.1348309467656 17.8661106847571,47.1365858661705 17.8672645003606,47.1383090084483 17.8671758191601,47.1384423199865 17.8784986798718,47.1398105097686 17.8815319955792,47.1398414557817 17.883278222373,"
Print #1, "      47.1392678024837 17.8921821984699,47.1390060086441"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 16</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9411119839045,47.1396348404465 17.9406024696582,47.1394851603694 17.9403454962396,47.1412173667663 17.9394919700992,47.1425764735442 17.9382808854929,47.1444634381924 17.9387838890503,"
Print #1, "      47.1445414534089 17.9393310339631,47.143625878321 17.9391353966198,47.1436239837091 17.9411859220633,47.1396552574936 17.9411119839045,47.1396348404465"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 17</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9608779011519,47.1428735734635 17.9585894260763,47.1425185037926 17.9583323438224,47.1435616189251 17.9561450196593,47.1467578929697 17.9549416380554,47.1479528282335 17.9525611605728,"
Print #1, "      47.1490560681313 17.9506719392371,47.1491989240929 17.9479767361723,47.150771454602 17.9540191787536,47.1526892574108 17.9608779011519,47.1428735734635"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 18</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.8734953480632,47.1923837435906 17.87325271854,47.1923325550715 17.8733458800534,47.191356904482 17.8733449282472,47.1913616970988 17.8732360978809,47.1924361984502 17.8734953480632,"
Print #1, "      47.1923837435906"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 19 </name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.8212872985323,47.1811105180213 17.8210435778644,47.1808426628916 17.8207809896365,47.1810925806864 17.8208713359312,47.181134482743 17.8212872985323,47.1811105180213"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 20</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9187458266541,47.1980986119914 17.9193238858601,47.1980512443389 17.9193386729001,47.198069742561 17.9194777548338,47.1980715619526 17.919476232908,47.1980499556725 17.9198102629188,"
Print #1, "      47.1980146498261 17.9205726641199,47.1979767204992 17.920988932046,47.1979223382062 17.9214281638772,47.1978757433898 17.9195473233951,47.1978572399414 17.9188418226986,47.1980626957502 17.9187458266541,47.1980986119914</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.9105575450132,47.2008515183937 17.9105684404245,47.2008404763585 17.9105230023723,47.2008499353069 17.9105575450132,47.2008515183937</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.9082160953743,47.2021663805114 17.9083013924548,47.2020533949702 17.9080548893682,47.2021965735911 17.9080717042746,47.2022085770482 17.9082160953743,47.2021663805114</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.9074724206925,47.2026085323002 17.9075440713136,47.2024932725201 17.9073608916195,47.20259966759 17.9074724206925,47.2026085323002</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.9072257754822,47.2027161035844 17.907222825359,47.2026798592419 17.906728600923,47.2029669113509 17.9068427668623,47.2029900094222 17.9070662189392,47.2028806787001 17.9070932055499,47.2028102357357 17.9072257754822,47.2027161035844</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.8940279764117,47.2039220555932 17.8930381201595,47.2027118228939 17.8934844999635,47.2034389348896 17.8940279764117,47.2039220555932</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.9033953358775,47.204923055656 17.9036344199255,47.2047934658047 17.9038288796264,47.2047991855185 17.9038951352636,47.2047875218027 17.9039542519279,47.204641200849 17.9040204858119,"
Print #1, "      47.2046059663118 17.9042372060234,47.2046016516215 17.9043436713873,47.2044941275322 17.9043961019972,47.2044070258365 17.9044746681799,47.2043568901139 17.9045955811457,47.20433263654 17.9046456625187,47.2042626943971 17.9047404464301,"
Print #1, "      47.2041765547899 17.9049478926635,47.204130672935 17.9051413541459,47.2040290536075 17.905310216098,47.2040279482489 17.90537238888,47.203966582939 17.9053884709678,47.2038323372474 17.9056048310472,47.2036354937581 17.9057850365045,"
Print #1, "      47.2035854704659 17.9058660356978,47.2034710338939 17.9062045709635,47.2032892610584 17.9063134499063,47.2032104576914 17.9065418783915,47.2031153918318 17.9065637027102,47.2030626852548 17.903224328583,47.205002088945 17.9033953358775,47.204923055656</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.898124995772,47.2056484952427 17.8986009279111,47.2055493601762 17.8987660210305,47.2056191181973 17.8991293116294,47.2055766084158 17.8995247848503,47.20564552539 17.8996553278971,"
Print #1, "      47.2055973530957 17.8998633791706,47.2056524259325 17.9001940057982,47.2055390538988 17.9004995783304,47.205540673889 17.9007206122978,47.2054956553362 17.9007757525708,47.2054424087942 17.9008685167745,47.2054258841747 17.9012136442914,"
Print #1, "      47.2054664926241 17.9013725303454,47.2055548972548 17.9016855828107,47.2054605074688 17.9018352392387,47.2053644831374 17.9020658128355,47.205317758119 17.9022724325696,47.2052615269362 17.9024726778484,47.2052683863284 17.9027424375402,"
Print #1, "      47.2051612359784 17.9030435965682,47.2050856161091 17.9031795224675,47.2050227966044 17.8968748052749,47.2051716494571 17.8967167416212,47.20511275495 17.8943884719626,47.2042425100525 17.8947014017454,47.2045206779251 17.8955833950937,"
Print #1, "      47.2054214518519 17.898124995772,47.2056484952427"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 21</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.8460027433622,47.095823120775 17.8459972750301,47.0958128875438 17.8458902548548,47.0958652315186 17.8460027433622,47.095823120775</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.8572693851245,47.1090657664397 17.8612659589652,47.106418918439 17.8632207347686,47.1047341382845 17.8623375513985,47.1040690453988 17.8633490633617,47.1026818986038 17.8650362699596,"
Print #1, "      47.1015928626577 17.8671148481686,47.1001585042039 17.8675248367483,47.0989688841972 17.8649819669193,47.0982729071459 17.8660981060433,47.0979351052697 17.8674112428531,47.0983271525731 17.8686093708266,47.098135737777 17.8695795837589,"
Print #1, "      47.0986115811556 17.8708223162167,47.0983331555935 17.873454733101,47.0969043821827 17.8748928087746,47.0954923662354 17.876358774572,47.0947504160624 17.8767124351097,47.094591019373 17.8773977505645,47.0938699390718 17.8822597441634,"
Print #1, "      47.0885644527546 17.8824112793537,47.0883992000095 17.8801404616066,47.0876492890342 17.8775859042726,47.0856420301095 17.8775872191636,47.085642133532 17.8755306115508,47.0836877831717 17.874152438238,47.0843853487209 17.874152101713,"
Print #1, "      47.0843855510192 17.8718697211098,47.0850454861787 17.8700736755285,47.0855399900446 17.8700736240679,47.0855399841189 17.8679869242033,47.0857294393597 17.8679868741063,47.0857294457419 17.8674443048176,47.0858189355899 17.8670171933885,"
Print #1, "      47.0858893816033 17.8668312421204,47.0859200345424 17.8654501410281,47.0861064777374 17.866520275321,47.0869126606274 17.8638939005511,47.0885102032047 17.8623869943867,47.0894463465332 17.8605802206276,47.090086607845 17.8601715491964,"
Print #1, "      47.0903079104006 17.859395095745,47.0908659132701 17.8581667867656,47.0914358553349 17.8564668291513,47.092384219437 17.8557067245452,47.0927911344397 17.8538552717758,47.0938179514588 17.8522450384751,47.0947766371942 17.8504950750625,"
Print #1, "      47.0957305992559 17.8488987625789,47.0954199563019 17.8483406310706,47.095378193991 17.8490092519046,47.0958121046844 17.8510624981714,47.0972777499413 17.8525517465423,47.0983418819238 17.8525856362218,47.0983581601318 17.8513098717985,"
Print #1, "      47.0998520300896 17.8510662313338,47.0999649981623 17.850623528886,47.1001535234808 17.8506477655826,47.1001772584025 17.8517760437746,47.1009197692532 17.851889734657,47.1009908619085 17.8521833700325,47.1018333183792 17.8528105323031,"
Print #1, "      47.1027858688787 17.8536220194915,47.1039693043988 17.8532174511872,47.1040719602212 17.8543127738281,47.1066337591957 17.8546363381538,47.1065892724075 17.8554651278304,47.1074982964652 17.8550615603275,47.1075551765762 17.8547908793605,"
Print #1, "      47.1077152830182 17.8558924209426,47.1102001175178 17.8561223185121,47.1102025124742 17.8572693851245,47.1090657664397</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.8450356053737,47.1121632781953 17.8451011561518,47.1120848868462 17.8452349189777,47.1120145897187 17.8454376932234,47.1120279667475 17.8455628102877,47.1119845682969 17.8456794906385,"
Print #1, "      47.1117717643171 17.8458307142164,47.1116458708101 17.8461063935937,47.1115935274349 17.8461583921698,47.1115257891139 17.8462040565278,47.1114993687804 17.8464038191348,47.1115235084523 17.8466699896097,47.111530531653 17.8467673668003,"
Print #1, "      47.1115426198197 17.8467545186508,47.1115864784975 17.8470650432182,47.1121285465456 17.8472697015881,47.1120524235675 17.8476622145488,47.1119440837716 17.8481191823744,47.1118409168595 17.8488600197332,47.1115905695229 17.8489487571554,"
Print #1, "      47.1115708071688 17.8491381515399,47.1115579472093 17.8496258898488,47.1115805997524 17.8499110770381,47.111579987501 17.8501368741067,47.1115598599026 17.8503493826669,47.1115153018707 17.8505430901367,47.1114570517496 17.8506852736129,"
Print #1, "      47.1114045598236 17.8509450111852,47.1112813245305 17.8512321100069,47.1111719597451 17.8514735973284,47.1110926158786 17.8516219829701,47.1110572812579 17.8521821763867,47.1109632744848 17.8525410422695,47.1109148438991 17.8528956188125,"
Print #1, "      47.1108519727905 17.8530659117928,47.1108033701829 17.8530789084478,47.110814766832 17.854523827063,47.1103159418523 17.8538958210391,47.1083599103594 17.8538127482794,47.108427147845 17.8532050586367,47.108619179474 17.8528118391248,"
Print #1, "      47.108560733034 17.852285178371,47.1085943658147 17.8509573040423,47.1086880811376 17.850900988405,47.1087019765363 17.8503189816425,47.107749709628 17.8501983298695,47.1076946467302 17.8499428108781,47.107577984082 17.8495854007562,"
Print #1, "      47.1075742410849 17.8493618383132,47.1075718992474 17.8493078677594,47.1075401154978 17.8490114988966,47.1072477682199 17.8488507270282,47.1071721309629 17.8484806796416,47.1069980355878 17.8481785482168,47.1068684648583 17.8478608912419,"
Print #1, "      47.1067320729458 17.8474491919066,47.1066056692918 17.8470923582483,47.1066175786512 17.8465889697262,47.106642432696 17.8461173131572,47.1067443592584 17.8454807989514,47.1063091608576 17.845197866955,47.1061058314687 17.8447828932721,"
Print #1, "      47.1062185146115 17.8447171298187,47.1062423838539 17.8447326264432,47.1057073361479 17.8445964542437,47.1057974898579 17.8443111418904,47.1055656137763 17.844654322927,47.1052182643923 17.8443202091535,47.1041770759449 17.8441259808541,"
Print #1, "      47.1041133153026 17.8440318084941,47.1040824554452 17.8432773671486,47.1040286307821 17.8391880161106,47.103736919332 17.8385093569498,47.1036884521088 17.8382450935958,47.1040464243363 17.8381404210614,47.1041881845166 17.8379582012078,"
Print #1, "      47.1043388408597 17.8376007186105,47.1042579580253 17.8363984758113,47.1039927861202 17.8345139402345,47.1034630619062 17.83521015851,47.1024028993249 17.8359275583327,47.1012501113746 17.8363868404202,47.1007056396313 17.8374088987495,"
Print #1, "      47.0999839505381 17.8377574934149,47.0993925990042 17.8382979168226,47.0988865565237 17.8379211806473,47.0989629437359 17.8379085674394,47.0991240306771 17.8375128766074,47.099718213107 17.8372214531482,47.1001124221681 17.8368003723386,"
Print #1, "      47.1003096702216 17.8367128529189,47.1003634433634 17.8365440522422,47.1005095612666 17.8363491450919,47.1006564820337 17.8361768809207,47.1008041821276 17.8360713694495,47.1009075158047 17.835990718522,47.1010126422018 17.8359166868665,"
Print #1, "      47.1011337627839 17.8357696335548,47.1014706595022 17.8350839263023,47.1022666146144 17.834698597297,47.102889416893 17.8345464960542,47.1031580637695 17.8343290580497,47.1034606545456 17.8342369936506,47.1036038045515 17.8340325747562,"
Print #1, "      47.1038726154461 17.8338519277346,47.1042489185865 17.8336032993923,47.1047231034064 17.8335129271481,47.1048322633878 17.8334083685821,47.105014685536 17.8332957834422,47.1051560875202 17.8331924126811,47.1053904328785 17.8331889380824,"
Print #1, "      47.1054272823368 17.8330845765869,47.1056067373865 17.8330543711932,47.1057122174901 17.8330156774993,47.1058027629397 17.8326540743452,47.1062495647695 17.831698068067,47.1102551591291 17.8323622534671,47.1102887575567 17.8324575059904,"
Print #1, "      47.1103996187621 17.8326401865692,47.1104211719951 17.8329732847515,47.1104054566816 17.8330659974085,47.1102345148847 17.8333847872551,47.1102163073292 17.8335350951073,47.1103805624344 17.833847017008,47.1103167575781 17.8343440259013,"
Print #1, "      47.1102787563511 17.8343353458438,47.1101737632083 17.8344565591951,47.1101515675468 17.8345528075552,47.1101667130531 17.8348818065952,47.110250001973 17.8349752664936,47.1102545014981 17.8351484302652,47.1102425722245 17.8354714411904,"
Print #1, "      47.1101951644643 17.8356058182709,47.1102257375425 17.8356009788862,47.110334275944 17.835929287005,47.1103669033146 17.8361019267633,47.1099431000138 17.8363689539674,47.1099584332607 17.8365235817787,47.1100198983031 17.8365174349187,"
Print #1, "      47.1101396687064 17.8368942064927,47.1101504047509 17.8368390048939,47.1103471171496 17.8369658430037,47.1104021696917 17.8370516508368,47.1104128841884 17.837151056928,47.1101845214228 17.8374432545412,47.1102289078034 17.8373952268662,"
Print #1, "      47.1103709067095 17.8376852303443,47.110442349177 17.8379123646305,47.1104504193595 17.8378897453225,47.1102509042344 17.8382294940631,47.110214911551 17.8384816906562,47.1102160482662 17.838617170013,47.1102329545287 17.8385781180325,"
Print #1, "      47.1103918725079 17.8386528500464,47.1104261299317 17.8387151519224,47.1103692997705 17.8388159500093,47.11025358845 17.8389456354552,47.1102354361116 17.8391557258686,47.1102686943006 17.8391948840981,47.1100584963393 17.8393228591383,"
Print #1, "      47.1100809004152 17.8393512392984,47.1100962246096 17.839446617922,47.110219586533 17.8394111048388,47.1102864164272 17.8394929151778,47.1102874604498 17.8395493116041,47.1103458145883 17.8397139882138,47.1104001840732 17.8397621987357,"
Print #1, "      47.1103719938372 17.8397913941715,47.1103687934249 17.8400095139827,47.1102977736625 17.8401420472829,47.110276051377 17.8403812804729,47.1099592853452 17.8404622715011,47.1099790330676 17.8405537170778,47.1100375766535 17.8405800863456,"
Print #1, "      47.110077710076 17.8405374655484,47.1101733445513 17.8404609707815,47.11025764562 17.8403390819701,47.1104901821795 17.8405800001418,47.1105704557094 17.8407011789851,47.1105322390552 17.8408769982549,47.1105543364762 17.8409467959469,"
Print #1, "      47.1105737858237 17.8409992831323,47.1106244508348 17.8409481360839,47.1107765844343 17.8410003788635,47.1108205893427 17.8410252324567,47.1109684865137 17.8409286194937,47.1111439816247 17.8408897537278,47.11118432644 17.8413066352874,"
Print #1, "      47.1114669898278 17.8412859227961,47.1115495405547 17.8413793316461,47.1117020291268 17.8414465565119,47.1117479011591 17.841512305305,47.1117541723421 17.8416503150618,47.1117235093807 17.8416899290409,47.1117258163045 17.8417102648938,"
Print #1, "      47.111753110594 17.8417414661334,47.1118651778606 17.8417966351189,47.1118730467104 17.8419752354298,47.1118015166233 17.842083396118,47.1118029264593 17.8422718423709,47.11176217824 17.8423100037594,47.1118112521971 17.8423975349025,"
Print #1, "      47.1118916148392 17.8424529493159,47.1118886899835 17.8425537337692,47.1118666303844 17.8426801363532,47.1118772284708 17.8428979759478,47.1119178485992 17.8430340841921,47.111953829078 17.8432355427353,47.1119204136151 17.8433775405818,"
Print #1, "      47.1119348637496 17.8433599537313,47.1119958557754 17.8433643199625,47.1120300889845 17.8434652719195,47.1120997961034 17.8435440725526,47.112111691456 17.843618967631,47.1120747838452 17.8436870236424,47.1119964196521 17.8437188141209,"
Print #1, "      47.1119950448732 17.8437909031695,47.1120590499453 17.8440031009246,47.1121103145828 17.8442271618244,47.1120213560195 17.8444150237477,47.1120940457794 17.8445042448966,47.1121113580935 17.8447185008848,47.1120889605586 17.8448388083222,"
Print #1, "      47.112223735756 17.8448810478308,47.1122206711927 17.8450356053737,47.1121632781953"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"

Print #1, "<Placemark>       <name>Országos Ökológiai Hálózat 22</name> <styleUrl>#poly-E65100-1200-23-nodesc</styleUrl> "
 Print #1, "<MultiGeometry><Polygon><outerBoundaryIs><LinearRing><coordinates>"
Print #1, "17.9844913679223,47.0801020656716 17.984476588388,47.0800770980033 17.9844766437047,47.0800771179915 17.9843973861602,47.0799429502394 17.9839619338506,47.0799691854529 17.9838575602011,"
Print #1, "      47.0801253178014 17.9846338003386,47.0803433256648 17.9844913679223,47.0801020656716</coordinates></LinearRing></outerBoundaryIs></Polygon><Polygon><outerBoundaryIs><LinearRing><coordinates>17.95819911399,47.0818909686534 17.9581631455406,"
Print #1, "      47.0818478297205 17.9581630280495,47.0818478436456 17.9567399365956,47.0820164994754 17.9557200512132,47.0821606008721 17.9570852228946,47.082209794439 17.9589574128286,47.0831585957498 17.9599789974308,47.0820512256694 17.95819911399,47.0818909686534</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.9686331053819,47.103958288251 17.9686576315718,47.0921530142958 17.9687651066468,47.0917631321863 17.9690648725154,47.0900460165676 17.9695028132196,47.0889534780414 17.9702397334268,"
Print #1, "      47.0881676562373 17.9722532637416,47.0871064077443 17.9760545890098,47.0859477303637 17.9771986039761,47.0855239186697 17.9774359591647,47.0855103970102 17.977431423455,47.0853819751057 17.9754287465094,47.0846341370758 17.9751038055647,"
Print #1, "      47.083691408535 17.9751415874215,47.0818124015051 17.9779320614395,47.0802677265554 17.9766787478644,47.0803298969873 17.9741378307321,47.0804421805422 17.9732864762568,47.0804899606115 17.9728386985823,47.0805223670646 17.971703689691,"
Print #1, "      47.0805815925404 17.9715523468187,47.0805955510665 17.9706605336621,47.080629634821 17.9637024792849,47.0923734323346 17.9622295434618,47.0925509945073 17.9576904591073,47.0914051178432 17.9562254820906,47.0944446388429 17.9554439945731,"
Print #1, "      47.0974371422835 17.9561550374916,47.0978864678558 17.9549264572519,47.1016121392153 17.9595217775578,47.1022953332198 17.963462727285,47.1030133437222 17.9681040023105,47.1038586524941 17.9685840735836,47.1039461302624 17.9686331053819,47.103958288251</coordinates></LinearRing></outerBoundaryIs></Polygon>"
Print #1, "      <Polygon><outerBoundaryIs><LinearRing><coordinates>17.988684124708,47.106442584226 17.9877452770615,47.1041505081358 17.9875618697312,47.1035473979118 17.9871451961999,47.1016622940659 17.9873766760126,47.1013356817488 17.9872180123157,"
Print #1, "      47.1008476202468 17.9877815854295,47.1007643200404 17.9875911913534,47.1010330018816 17.9878704122772,47.1006390170555 17.9884587381135,47.0992762922915 17.9888235798022,47.0980603870489 17.9900196493019,47.0971786508895 17.988125954777,"
Print #1, "      47.0963252626041 17.9874443939425,47.0960836888743 17.9876217073055,47.0949706754678 17.9879494459605,47.0931221583372 17.9885047708154,47.0921831283702 17.9879798272151,47.0909832684883 17.9876658586002,47.0900122519564 17.9876381777038,"
Print #1, "      47.0894432415997 17.9875318203056,47.0887436822198 17.9871807579095,47.0880494101597 17.9876338058855,47.0866875022954 17.9878393957586,47.0845937773946 17.9887194580817,47.0840910245496 17.9881705809277,47.0837351678586 17.9855734746774,"
Print #1, "      47.0824425704282 17.9852187590607,47.0813333407902 17.9849619045365,47.0808985551229 17.9849618668304,47.0808985781451 17.9847502486342,47.0805402727959 17.9846339142494,47.0803433445546 17.9831494497821,47.0818194158105 17.9838430636773,"
Print #1, "      47.0821201464291 17.9827069459289,47.083197059704 17.9815766647537,47.0826551045471 17.9785870553702,47.0857902506672 17.9813052177887,47.0866211779005 17.9826779166181,47.0855613263783 17.9825586464393,47.085749500572 17.9842244326764,"
Print #1, "      47.0875924551477 17.9850398685307,47.090846762096 17.9807864729805,47.0966391856486 17.98489971637,47.0978799501164 17.9829576822317,47.1025516325686 17.9746339044732,47.1004896726588 17.9735191393367,47.1057755903319 17.9757404195861,"
Print #1, "      47.1067972831371 17.976642943266,47.1056792053878 17.9775474797142,47.1044852096404 17.9791236916787,47.1049207998015 17.9801320740528,47.1073352302701 17.9897073958297,47.1085063798825 17.9896886716812,47.1084488178531 17.9896373732473,"
Print #1, "      47.1083498967997 17.9896371141534,47.1083494622238 17.9896371193567,47.1083494072102 17.989260862933,47.1076238432257 17.988684124708,47.106442584226"
 Print #1, "</coordinates></LinearRing></outerBoundaryIs></Polygon></MultiGeometry>   </Placemark>"


Print #1, "    </Folder>"

Print #1, "</Document>"
Print #1, "</kml>"

Close #1
End Sub


