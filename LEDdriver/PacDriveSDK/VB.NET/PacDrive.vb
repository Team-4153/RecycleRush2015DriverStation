Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms

Class PacDrive
    Private m_mode64 As Boolean = False

    Public Enum DeviceType
        Unknown
        PacDrive
        UHID
        PacLED64
        ServoStik
		USBButton
		NanoLED
		IPACIO
    End Enum

    Public Enum FlashSpeed As Byte
        AlwaysOn = 0
        Seconds_2 = 1
        Seconds_1 = 2
        Seconds_0_5 = 3
    End Enum

    ' ================== 32-bit ====================

    <DllImport("PacDrive32.dll", EntryPoint:="PacSetCallbacks", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacSetCallbacks32(ByVal pacAttachedCallback As PAC_ATTACHED_CALLBACK, ByVal pacRemovedCallback As PAC_REMOVED_CALLBACK)
    End Sub

    <DllImport("PacDrive32.dll", EntryPoint:="PacInitialize", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacInitialize32() As Integer
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="PacShutdown", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacShutdown32()
    End Sub

    <DllImport("PacDrive32.dll", EntryPoint:="PacSetLEDStates", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacSetLEDStates32(ByVal id As Integer, ByVal data As UShort) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="PacSetLEDState", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacSetLEDState32(ByVal id As Integer, ByVal port As Integer, <MarshalAs(UnmanagedType.Bool)> ByVal state As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetLEDStates", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDStates32(ByVal id As Integer, ByVal group As Integer, ByVal data As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetLEDState", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDState32(ByVal id As Integer, ByVal group As Integer, ByVal port As Integer, <MarshalAs(UnmanagedType.Bool)> ByVal state As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetLEDStatesRandom", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDStatesRandom32(ByVal id As Integer) As Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetLEDIntensities", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDIntensities32(ByVal id As Integer, ByVal data As Byte()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetLEDIntensity", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDIntensity32(ByVal id As Integer, ByVal port As Integer, ByVal intensity As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetLEDFadeTime", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDFadeTime32(ByVal id As Integer, ByVal fadeTime As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetLEDFlashSpeeds", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDFlashSpeeds32(ByVal id As Integer, ByVal flashSpeed As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetLEDFlashSpeed", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDFlashSpeed32(ByVal id As Integer, ByVal port As Integer, ByVal flashSpeed As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64StartScriptRecording", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64StartScriptRecording32(ByVal id As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64StopScriptRecording", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64StopScriptRecording32(ByVal id As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetScriptStepDelay", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetScriptStepDelay32(ByVal id As Integer, ByVal stepDelay As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64RunScript", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64RunScript32(ByVal id As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64ClearFlash", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64ClearFlash32(ByVal id As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="Pac64SetDeviceId", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetDeviceId32(ByVal id As Integer, ByVal newId As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="PacGetDeviceType", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacGetDeviceType32(ByVal id As Integer) As Integer
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="PacGetVendorId", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacGetVendorId32(ByVal Id As Integer) As Integer
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="PacGetProductId", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacGetProductId32(ByVal Id As Integer) As Integer
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="PacGetVersionNumber", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacGetVersionNumber32(ByVal Id As Integer) As Integer
    End Function

    <DllImport("PacDrive32.dll", EntryPoint:="PacGetVendorName", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacGetVendorName32(ByVal Id As Integer, ByVal VendorName As StringBuilder)
    End Sub

    <DllImport("PacDrive32.dll", EntryPoint:="PacGetProductName", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacGetProductName32(ByVal Id As Integer, ByVal ProductName As StringBuilder)
    End Sub

    <DllImport("PacDrive32.dll", EntryPoint:="PacGetSerialNumber", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacGetSerialNumber32(ByVal Id As Integer, ByVal SerialNumber As StringBuilder)
    End Sub

    <DllImport("PacDrive32.dll", EntryPoint:="PacGetDevicePath", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacGetDevicePath32(ByVal Id As Integer, ByVal DevicePath As StringBuilder)
    End Sub

    <DllImport("PacDrive32.dll", EntryPoint:="PacProgramUHid", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacProgramUHid32(ByVal id As Integer, ByVal FileName As StringBuilder) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

	<DllImport("PacDrive32.dll", EntryPoint:="PacSetServoStik4Way", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function PacSetServoStik4Way32() As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive32.dll", EntryPoint:="PacSetServoStik8Way", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function PacSetServoStik8Way32() As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive32.dll", EntryPoint:="USBButtonConfigurePermanent", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function USBButtonConfigurePermanent32(ByVal id As Integer, ByVal data As Byte()) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive32.dll", EntryPoint:="USBButtonConfigureTemporary", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function USBButtonConfigureTemporary32(ByVal id As Integer, ByVal data As Byte()) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive32.dll", EntryPoint:="USBButtonConfigureColor", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function USBButtonConfigureColor32(ByVal id As Integer, ByVal red As Byte, ByVal green As Byte, ByVal blue As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive32.dll", EntryPoint:="USBButtonGetState", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function USBButtonGetState32(ByVal id As Integer, <MarshalAs(UnmanagedType.Bool)> ByRef state As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

    ' ================== 64-bit ====================

    <DllImport("PacDrive64.dll", EntryPoint:="PacSetCallbacks", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacSetCallbacks64(ByVal pacAttachedCallback As PAC_ATTACHED_CALLBACK, ByVal pacRemovedCallback As PAC_REMOVED_CALLBACK)
    End Sub

    <DllImport("PacDrive64.dll", EntryPoint:="PacInitialize", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacInitialize64() As Integer
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="PacShutdown", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacShutdown64()
    End Sub

    <DllImport("PacDrive64.dll", EntryPoint:="PacSetLEDStates", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacSetLEDStates64(ByVal id As Integer, ByVal data As UShort) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="PacSetLEDState", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacSetLEDState64(ByVal id As Integer, ByVal port As Integer, <MarshalAs(UnmanagedType.Bool)> ByVal state As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetLEDStates", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDStates64(ByVal id As Integer, ByVal group As Integer, ByVal data As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetLEDState", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDState64(ByVal id As Integer, ByVal group As Integer, ByVal port As Integer, <MarshalAs(UnmanagedType.Bool)> ByVal state As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetLEDStatesRandom", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDStatesRandom64(ByVal id As Integer) As Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetLEDIntensities", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDIntensities64(ByVal id As Integer, ByVal data As Byte()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetLEDIntensity", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDIntensity64(ByVal id As Integer, ByVal port As Integer, ByVal intensity As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetLEDFadeTime", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDFadeTime64(ByVal id As Integer, ByVal fadeTime As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetLEDFlashSpeeds", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDFlashSpeeds64(ByVal id As Integer, ByVal flashSpeed As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetLEDFlashSpeed", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetLEDFlashSpeed64(ByVal id As Integer, ByVal port As Integer, ByVal flashSpeed As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64StartScriptRecording", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64StartScriptRecording64(ByVal id As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64StopScriptRecording", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64StopScriptRecording64(ByVal id As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetScriptStepDelay", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetScriptStepDelay64(ByVal id As Integer, ByVal stepDelay As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64RunScript", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64RunScript64(ByVal id As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64ClearFlash", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64ClearFlash64(ByVal id As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="Pac64SetDeviceId", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function Pac64SetDeviceId64(ByVal id As Integer, ByVal newId As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="PacGetDeviceType", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacGetDeviceType64(ByVal id As Integer) As Integer
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="PacGetVendorId", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacGetVendorId64(ByVal Id As Integer) As Integer
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="PacGetProductId", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacGetProductId64(ByVal Id As Integer) As Integer
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="PacGetVersionNumber", CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacGetVersionNumber64(ByVal Id As Integer) As Integer
    End Function

    <DllImport("PacDrive64.dll", EntryPoint:="PacGetVendorName", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacGetVendorName64(ByVal Id As Integer, ByVal VendorName As StringBuilder)
    End Sub

    <DllImport("PacDrive64.dll", EntryPoint:="PacGetProductName", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacGetProductName64(ByVal Id As Integer, ByVal ProductName As StringBuilder)
    End Sub

    <DllImport("PacDrive64.dll", EntryPoint:="PacGetSerialNumber", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacGetSerialNumber64(ByVal Id As Integer, ByVal SerialNumber As StringBuilder)
    End Sub

    <DllImport("PacDrive64.dll", EntryPoint:="PacGetDevicePath", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Sub PacGetDevicePath64(ByVal Id As Integer, ByVal DevicePath As StringBuilder)
    End Sub

    <DllImport("PacDrive64.dll", EntryPoint:="PacProgramUHid", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PacProgramUHid64(ByVal id As Integer, ByVal FileName As StringBuilder) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

	<DllImport("PacDrive64.dll", EntryPoint:="PacSetServoStik4Way", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function PacSetServoStik4Way64() As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive64.dll", EntryPoint:="PacSetServoStik8Way", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function PacSetServoStik8Way64() As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive64.dll", EntryPoint:="USBButtonConfigurePermanent", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function USBButtonConfigurePermanent64(ByVal id As Integer, ByVal data As Byte()) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive64.dll", EntryPoint:="USBButtonConfigureTemporary", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function USBButtonConfigureTemporary64(ByVal id As Integer, ByVal data As Byte()) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive64.dll", EntryPoint:="USBButtonConfigureColor", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function USBButtonConfigureColor64(ByVal id As Integer, ByVal red As Byte, ByVal green As Byte, ByVal blue As Byte) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	<DllImport("PacDrive64.dll", EntryPoint:="USBButtonGetState", CallingConvention:=CallingConvention.Cdecl)> _
	Private Shared Function USBButtonGetState64(ByVal id As Integer, <MarshalAs(UnmanagedType.Bool)> ByRef state As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

    Private Delegate Sub PAC_ATTACHED_CALLBACK(ByVal id As Integer)
    Private Delegate Sub PAC_REMOVED_CALLBACK(ByVal id As Integer)

    Public Delegate Sub PacAttachedDelegate(ByVal id As Integer)
    Public Delegate Sub PacRemovedDelegate(ByVal id As Integer)

    Public Event OnPacAttached As PacAttachedDelegate
    Public Event OnPacRemoved As PacRemovedDelegate

    <MarshalAs(UnmanagedType.FunctionPtr)> _
    Private PacAttachedCallbackPtr As PAC_ATTACHED_CALLBACK = Nothing

    <MarshalAs(UnmanagedType.FunctionPtr)> _
    Private PacRemovedCallbackPtr As PAC_REMOVED_CALLBACK = Nothing

    Private m_ctrl As Control
    Private m_numDevices As Integer = 0

    Public Sub New(ByVal ctrl As Control)
        m_ctrl = ctrl
        m_mode64 = Is64BitMode()

        PacAttachedCallbackPtr = New PAC_ATTACHED_CALLBACK(AddressOf PacAttachedCallback)
        PacRemovedCallbackPtr = New PAC_REMOVED_CALLBACK(AddressOf PacRemovedCallback)

        If m_mode64 Then
            PacSetCallbacks64(PacAttachedCallbackPtr, PacRemovedCallbackPtr)
        Else
            PacSetCallbacks32(PacAttachedCallbackPtr, PacRemovedCallbackPtr)
        End If
    End Sub

    Private Sub PacAttachedCallback(ByVal id As Integer)
        m_numDevices += 1

        RaiseEvent OnPacAttached(id)
    End Sub

    Private Sub PacRemovedCallback(ByVal id As Integer)
        m_numDevices -= 1

        RaiseEvent OnPacRemoved(id)
    End Sub

    Public Function Initialize() As Integer
        If m_mode64 Then
            m_numDevices = PacInitialize64()
        Else
            m_numDevices = PacInitialize32()
        End If

        Return m_numDevices
    End Function

    Public Sub Shutdown()
        If m_mode64 Then
            PacShutdown64()
        Else
            PacShutdown32()
        End If
    End Sub

    Public Function SetLEDStates(ByVal Id As Integer, ByVal Data As UShort) As Boolean
        If m_mode64 Then
            Return PacSetLEDStates64(Id, Data)
        Else
            Return PacSetLEDStates32(Id, Data)
        End If
    End Function

    Public Function SetLEDState(ByVal Id As Integer, ByVal Port As Integer, ByVal State As Boolean) As Boolean
        If m_mode64 Then
            Return PacSetLEDState64(Id, Port, State)
        Else
            Return PacSetLEDState32(Id, Port, State)
        End If
    End Function

    Public Function SetLEDStates(ByVal Id As Integer, ByVal Data As Boolean()) As Boolean
        Dim dataSend As UShort = 0

        For i As Integer = 0 To Data.Length - 1
            If Data(i) Then
                dataSend = dataSend Or CUShort(1 << i)
            End If
        Next

        If m_mode64 Then
            Return PacSetLEDStates64(Id, dataSend)
        Else
            Return PacSetLEDStates32(Id, dataSend)
        End If
    End Function

    Public Function SetLED64States(ByVal Id As Integer, ByVal Group As Integer, ByVal Data As Byte) As Boolean
        If m_mode64 Then
            Return Pac64SetLEDStates64(Id, Group, Data)
        Else
            Return Pac64SetLEDStates32(Id, Group, Data)
        End If
    End Function

    Public Function SetLED64States(ByVal Id As Integer, ByVal Group As Integer, ByVal Data As Boolean()) As Boolean
        Dim dataSend As Byte = 0

        For i As Integer = 0 To Data.Length - 1
            If Data(i) Then
                dataSend = dataSend Or CByte(1 << i)
            End If
        Next

        If m_mode64 Then
            Return Pac64SetLEDStates64(Id, Group, dataSend)
        Else
            Return Pac64SetLEDStates32(Id, Group, dataSend)
        End If
    End Function

    Public Function SetLED64StatesRandom(ByVal Id As Integer) As Boolean
        If m_mode64 Then
            Return Pac64SetLEDStatesRandom64(Id)
        Else
            Return Pac64SetLEDStatesRandom32(Id)
        End If
    End Function

    Public Function SetLED64Intensities(ByVal Id As Integer, ByVal Data As Byte()) As Boolean
        If m_mode64 Then
            Return Pac64SetLEDIntensities64(Id, Data)
        Else
            Return Pac64SetLEDIntensities32(Id, Data)
        End If
    End Function

    Public Function SetLED64Intensity(ByVal Id As Integer, ByVal Port As Integer, ByVal Intensity As Byte) As Boolean
        If m_mode64 Then
            Return Pac64SetLEDIntensity64(Id, Port, Intensity)
        Else
            Return Pac64SetLEDIntensity32(Id, Port, Intensity)
        End If
    End Function

    Public Function SetLED64FadeTime(ByVal Id As Integer, ByVal FadeTime As Byte) As Boolean
        If m_mode64 Then
            Return Pac64SetLEDFadeTime64(Id, FadeTime)
        Else
            Return Pac64SetLEDFadeTime32(Id, FadeTime)
        End If
    End Function

    Public Function SetLED64FlashSpeeds(ByVal Id As Integer, ByVal FlashSpeed As FlashSpeed) As Boolean
        If m_mode64 Then
            Return Pac64SetLEDFlashSpeeds64(Id, CByte(FlashSpeed))
        Else
            Return Pac64SetLEDFlashSpeeds32(Id, CByte(FlashSpeed))
        End If
    End Function

    Public Function SetLED64FlashSpeed(ByVal Id As Integer, ByVal Port As Integer, ByVal FlashSpeed As FlashSpeed) As Boolean
        If m_mode64 Then
            Return Pac64SetLEDFlashSpeed64(Id, Port, CByte(FlashSpeed))
        Else
            Return Pac64SetLEDFlashSpeed32(Id, Port, CByte(FlashSpeed))
        End If
    End Function

    Public Function StartScriptRecording(ByVal Id As Integer) As Boolean
        If m_mode64 Then
            Return Pac64StartScriptRecording64(Id)
        Else
            Return Pac64StartScriptRecording32(Id)
        End If
    End Function

    Public Function StopScriptRecording(ByVal Id As Integer) As Boolean
        If m_mode64 Then
            Return Pac64StopScriptRecording64(Id)
        Else
            Return Pac64StopScriptRecording32(Id)
        End If
    End Function

    Public Function SetScriptStepDelay(ByVal Id As Integer, ByVal StepDelay As Byte) As Boolean
        If m_mode64 Then
            Return Pac64SetScriptStepDelay64(Id, StepDelay)
        Else
            Return Pac64SetScriptStepDelay32(Id, StepDelay)
        End If
    End Function

    Public Function RunScript(ByVal Id As Integer) As Boolean
        If m_mode64 Then
            Return Pac64RunScript64(Id)
        Else
            Return Pac64RunScript32(Id)
        End If
    End Function

    Public Function ClearFlash(ByVal Id As Integer) As Boolean
        If m_mode64 Then
            Return Pac64ClearFlash64(Id)
        Else
            Return Pac64ClearFlash32(Id)
        End If
    End Function

    Public Function SetDeviceId(ByVal Id As Integer, ByVal NewId As Integer) As Boolean
        If m_mode64 Then
            Return Pac64SetDeviceId64(Id, NewId)
        Else
            Return Pac64SetDeviceId32(Id, NewId)
        End If
    End Function

    Public Function GetDeviceType(ByVal Id As Integer) As DeviceType
        If m_mode64 Then
            Return CType(PacGetDeviceType64(Id), DeviceType)
        Else
            Return CType(PacGetDeviceType32(Id), DeviceType)
        End If
    End Function

    Public Function GetVendorId(ByVal Id As Integer) As Integer
        If m_mode64 Then
            Return PacGetVendorId64(Id)
        Else
            Return PacGetVendorId32(Id)
        End If
    End Function

    Public Function GetProductId(ByVal Id As Integer) As Integer
        If m_mode64 Then
            Return PacGetProductId64(Id)
        Else
            Return PacGetProductId32(Id)
        End If
    End Function

    Public Function GetVersionNumber(ByVal Id As Integer) As Integer
        If m_mode64 Then
            Return PacGetVersionNumber64(Id)
        Else
            Return PacGetVersionNumber32(Id)
        End If
    End Function

    Public Function GetVendorName(ByVal Id As Integer) As String
        Dim sb As New StringBuilder(256)

        If m_mode64 Then
            PacGetVendorName64(Id, sb)
        Else
            PacGetVendorName32(Id, sb)
        End If

        Return sb.ToString()
    End Function

    Public Function GetProductName(ByVal Id As Integer) As String
        Dim sb As New StringBuilder(256)

        If m_mode64 Then
            PacGetProductName64(Id, sb)
        Else
            PacGetProductName32(Id, sb)
        End If

        Return sb.ToString()
    End Function

    Public Function GetSerialNumber(ByVal Id As Integer) As String
        Dim sb As New StringBuilder(256)

        If m_mode64 Then
            PacGetSerialNumber64(Id, sb)
        Else
            PacGetSerialNumber32(Id, sb)
        End If

        Return sb.ToString()
    End Function

    Public Function GetDevicePath(ByVal Id As Integer) As String
        Dim sb As New StringBuilder(256)

        If m_mode64 Then
            PacGetDevicePath64(Id, sb)
        Else
            PacGetDevicePath32(Id, sb)
        End If

        Return sb.ToString()
    End Function

    Public Function ProgramUHid(ByVal Id As Integer, ByVal FileName As String) As Boolean
        Dim sb As New StringBuilder(FileName)

        If m_mode64 Then
            Return PacProgramUHid64(Id, sb)
        Else
            Return PacProgramUHid32(Id, sb)
        End If
    End Function

	Public Function SetServoStik4Way() As Boolean
		If m_mode64 Then
			Return PacSetServoStik4Way64()
		Else
			Return PacSetServoStik4Way32()
		End If

	End Function

	Public Function SetServoStik8Way() As Boolean
		If m_mode64 Then
			Return PacSetServoStik8Way64()
		Else
			Return PacSetServoStik8Way32()
		End If
	End Function

	Public Function SetUSBButtonConfigurePermanent(ByVal Id As Integer, ByVal Data As Byte()) As Boolean
		If m_mode64 Then
			Return USBButtonConfigurePermanent64(Id, Data)
		Else
			Return USBButtonConfigurePermanent32(Id, Data)
		End If
	End Function

	Public Function SetUSBButtonConfigureTemporary(ByVal Id As Integer, ByVal Data As Byte()) As Boolean
		If m_mode64 Then
			Return USBButtonConfigureTemporary64(Id, Data)
		Else
			Return USBButtonConfigureTemporary32(Id, Data)
		End If
	End Function

	Public Function SetUSBButtonConfigureColor(ByVal Id As Integer, ByVal Red As Byte, ByVal Green As Byte, ByVal Blue As Byte) As Boolean
		If m_mode64 Then
			Return USBButtonConfigureColor64(Id, Red, Green, Blue)
		Else
			Return USBButtonConfigureColor32(Id, Red, Green, Blue)
		End If
	End Function

	Public Function GetUSBButtonState(ByVal Id As Integer, ByRef State As Boolean) As Boolean
		If m_mode64 Then
			Return USBButtonGetState64(Id, State)
		Else
			Return USBButtonGetState32(Id, State)
		End If
	End Function

    Public ReadOnly Property NumDevices() As Integer
        Get
            Return m_numDevices
        End Get
    End Property

    Private Function Is64BitMode() As Boolean
        Return Marshal.SizeOf(GetType(IntPtr)) = 8
    End Function
End Class
