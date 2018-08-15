Imports System.Xml
Imports StandardConfData

Public Class recordaccess
    Public Shared Sub slmodify(index As Integer, method As Integer, yieldSubject As String)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "record.xml")
        Dim xnLast As XmlNode = xmlDoc.SelectSingleNode("ConferenceRecord").FirstChild
        Dim xnRecord As XmlNodeList = xmlDoc.SelectSingleNode("ConferenceRecord").ChildNodes
        For Each xnSingle As XmlNode In xnRecord
            Dim xeSingle As XmlElement = CType(xnSingle, XmlNode)
            If xeSingle.GetAttribute("index") = index - 1 Then
                xnLast = xeSingle
            End If
            If xeSingle.GetAttribute("index") = index Then
                Dim xeYield As XmlElement = xmlDoc.CreateElement("yieldto")
                xeYield.SetAttribute("method", method)
                xeYield.InnerText = yieldSubject
                xeSingle.AppendChild(xeYield)
                xmlDoc.SelectSingleNode("ConferenceRecord").InsertAfter(xeSingle, xnLast)
                Exit For
            End If
        Next xnSingle
        xmlDoc.Save(Form1.lastPath + "record.xml")
    End Sub

    Public Shared Sub mcAdd(index As Integer, nation As String)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "record.xml")
        Dim xnLast As XmlNode = xmlDoc.SelectSingleNode("ConferenceRecord").FirstChild
        Dim xnRecord As XmlNodeList = xmlDoc.SelectSingleNode("ConferenceRecord").ChildNodes
        For Each xnSingle As XmlNode In xnRecord
            Dim xeSingle As XmlElement = CType(xnSingle, XmlNode)
            If xeSingle.GetAttribute("index") = index - 1 Then
                xnLast = xeSingle
            End If
            If xeSingle.GetAttribute("index") = index Then
                Dim xnList As XmlNode = xnSingle.ChildNodes(1)
                Dim xeList As XmlElement = CType(xnList, XmlNode)
                Dim xeSingleNation As XmlElement = xmlDoc.CreateElement("nation")
                xeSingleNation.SetAttribute("name", nation)
                xeList.AppendChild(xeSingleNation)
                xeSingle.AppendChild(xeList)
                xmlDoc.SelectSingleNode("ConferenceRecord").InsertAfter(xeSingle, xnLast)
                Exit For
            End If
        Next xnSingle
        xmlDoc.Save(Form1.lastPath + "record.xml")
    End Sub

    Public Shared Sub voteAdd(index As Integer, nations As String(), opini As MyInfo.VoteOpinion(), total As Integer, numbers As Integer(), passed As Boolean, veto As Boolean())
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "record.xml")
        Dim xnLast As XmlNode = xmlDoc.SelectSingleNode("ConferenceRecord").FirstChild
        Dim xnRecord As XmlNodeList = xmlDoc.SelectSingleNode("ConferenceRecord").ChildNodes
        For Each xnSingle As XmlNode In xnRecord
            Dim xeSingle As XmlElement = CType(xnSingle, XmlNode)
            If xeSingle.GetAttribute("index") = index - 1 Then
                xnLast = xeSingle
            End If
            If xeSingle.GetAttribute("index") = index Then
                Dim xnList As XmlNode = xnSingle.ChildNodes(1)
                Dim xeList As XmlElement = CType(xnList, XmlNode)
                xeList.SetAttribute("passed", passed)
                xeList.SetAttribute("presents", numbers(0))
                xeList.SetAttribute("passleast", numbers(1))
                xeList.SetAttribute("yes", numbers(2))
                xeList.SetAttribute("no", numbers(3))
                xeList.SetAttribute("abst", numbers(4))
                Dim xeVetoPower As XmlElement = xmlDoc.CreateElement("vetopower")
                xeVetoPower.SetAttribute("isveto", veto(0))
                xeVetoPower.SetAttribute("china", veto(1))
                xeVetoPower.SetAttribute("usa", veto(2))
                xeVetoPower.SetAttribute("uk", veto(3))
                xeVetoPower.SetAttribute("france", veto(4))
                xeVetoPower.SetAttribute("russia", veto(5))
                xeSingle.AppendChild(xeVetoPower)
                For i = 1 To total
                    Dim type1 = Convert.ChangeType(opini(i), [Enum].GetUnderlyingType(GetType(MyInfo.VoteOpinion)))
                    Dim xeSingleNation As XmlElement = xmlDoc.CreateElement("nation")
                    xeSingleNation.SetAttribute("name", nations(i))
                    xeSingleNation.SetAttribute("opinion", type1)
                    xeList.AppendChild(xeSingleNation)
                    xeSingle.AppendChild(xeList)
                Next
                xmlDoc.SelectSingleNode("ConferenceRecord").InsertAfter(xeSingle, xnLast)
                Exit For
            End If
        Next xnSingle
        xmlDoc.Save(Form1.lastPath + "record.xml")
    End Sub
End Class
