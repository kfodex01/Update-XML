﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System.Xml.Serialization

'
'This source code was auto-generated by xsd, Version=4.6.1055.0.
'

'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlRootAttribute("ESILAB-RMBS-ONLINE-PLATFORM", [Namespace]:="", IsNullable:=False)>
Partial Public Class PLATFORM_Type

    Private uploadsField() As Upload_Type

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("Upload", IsNullable:=False)>
    Public Property Uploads() As Upload_Type()
        Get
            Return Me.uploadsField
        End Get
        Set
            Me.uploadsField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code")>
Partial Public Class Upload_Type

    Private mainCategoryField As String

    Private subCategoryField As String

    Private dataPointField As String

    Private newValueField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("Main-Category")>
    Public Property MainCategory() As String
        Get
            Return Me.mainCategoryField
        End Get
        Set
            Me.mainCategoryField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("Sub-Category")>
    Public Property SubCategory() As String
        Get
            Return Me.subCategoryField
        End Get
        Set
            Me.subCategoryField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("Data-Point")>
    Public Property DataPoint() As String
        Get
            Return Me.dataPointField
        End Get
        Set
            Me.dataPointField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("New-Value")>
    Public Property NewValue() As String
        Get
            Return Me.newValueField
        End Get
        Set
            Me.newValueField = Value
        End Set
    End Property
End Class
