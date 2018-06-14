'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class station
    Public Property stationId As String
    Public Property stationName As String
    Public Property latitude As Nullable(Of Double)
    Public Property longitude As Nullable(Of Double)
    Public Property elevation As String
    Public Property geoLocationMethod As String
    Public Property geoLocationAccuracy As Nullable(Of Single)
    Public Property openingDatetime As Nullable(Of Date)
    Public Property closingDatetime As Nullable(Of Date)
    Public Property country As String
    Public Property authority As String
    Public Property adminRegion As String
    Public Property drainageBasin As String
    Public Property wacaSelection As Nullable(Of SByte)
    Public Property cptSelection As Nullable(Of SByte)
    Public Property stationOperational As Nullable(Of SByte)

    Public Overridable Property instruments As ICollection(Of instrument) = New HashSet(Of instrument)
    Public Overridable Property instrumentfaultreports As ICollection(Of instrumentfaultreport) = New HashSet(Of instrumentfaultreport)
    Public Overridable Property obsscheduleclasses As ICollection(Of obsscheduleclass) = New HashSet(Of obsscheduleclass)
    Public Overridable Property physicalfeatureclasses As ICollection(Of physicalfeatureclass) = New HashSet(Of physicalfeatureclass)
    Public Overridable Property observationfinal As observationfinal
    Public Overridable Property physicalfeature As physicalfeature

End Class
