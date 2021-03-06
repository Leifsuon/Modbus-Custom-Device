﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5477
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Modbus_Custom_Device {
    
    private Modbus_Custom_DeviceGeneral_Settings general_SettingsField;
    
    private object[] modbus_ItemsField;
    
    /// <remarks/>
    public Modbus_Custom_DeviceGeneral_Settings General_Settings {
        get {
            return this.general_SettingsField;
        }
        set {
            this.general_SettingsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Read_Coils", typeof(Modbus_Custom_DeviceRead_Coils), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Read_Discrete_Inputs", typeof(Modbus_Custom_DeviceRead_Discrete_Inputs), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Read_Holding_Registers", typeof(Modbus_Custom_DeviceRead_Holding_Registers), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Read_Input_Registers", typeof(Modbus_Custom_DeviceRead_Input_Registers), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Write_Multiple_Coils", typeof(Modbus_Custom_DeviceWrite_Multiple_Coils), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Write_Multiple_Discrete_Inputs", typeof(Modbus_Custom_DeviceWrite_Multiple_Discrete_Inputs), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Write_Multiple_Registers", typeof(Modbus_Custom_DeviceWrite_Multiple_Registers), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Write_Single_Coil", typeof(Modbus_Custom_DeviceWrite_Single_Coil), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Write_Single_Register", typeof(Modbus_Custom_DeviceWrite_Single_Register), IsNullable=false)]
    public object[] Modbus_Items {
        get {
            return this.modbus_ItemsField;
        }
        set {
            this.modbus_ItemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceGeneral_Settings {
    
    private Modbus_Custom_DeviceGeneral_SettingsModbus_Type modbus_TypeField;
    
    private Modbus_Custom_DeviceGeneral_SettingsCommunication_Type communication_TypeField;
    
    private long read_Write_Loop_PeriodField;
    
    private ushort tCP_Settings_PortField;
    
    private string tCP_Settings_IP_Slave_AddressField;
    
    private uint tCP_Settings_IP_TimeoutField;
    
    private string serial_Settings_Resource_NameField;
    
    private sbyte serial_Settings_Unit_IDField;
    
    private bool serial_Settings_Unit_IDFieldSpecified;
    
    private Modbus_Custom_DeviceGeneral_SettingsSerial_Settings_Serial_Type serial_Settings_Serial_TypeField;
    
    private bool serial_Settings_Serial_TypeFieldSpecified;
    
    private uint serial_Settings_Baud_RateField;
    
    private bool serial_Settings_Baud_RateFieldSpecified;
    
    private Modbus_Custom_DeviceGeneral_SettingsSerial_Settings_Parity serial_Settings_ParityField;
    
    private bool serial_Settings_ParityFieldSpecified;
    
    private Modbus_Custom_DeviceGeneral_SettingsSerial_Settings_Flow_Control serial_Settings_Flow_ControlField;
    
    private bool serial_Settings_Flow_ControlFieldSpecified;
    
    public Modbus_Custom_DeviceGeneral_Settings() {
        this.read_Write_Loop_PeriodField = ((long)(-1));
        this.tCP_Settings_PortField = ((ushort)(502));
        this.tCP_Settings_IP_TimeoutField = ((uint)(100));
    }
    
    /// <remarks/>
    public Modbus_Custom_DeviceGeneral_SettingsModbus_Type Modbus_Type {
        get {
            return this.modbus_TypeField;
        }
        set {
            this.modbus_TypeField = value;
        }
    }
    
    /// <remarks/>
    public Modbus_Custom_DeviceGeneral_SettingsCommunication_Type Communication_Type {
        get {
            return this.communication_TypeField;
        }
        set {
            this.communication_TypeField = value;
        }
    }
    
    /// <remarks/>
    public long Read_Write_Loop_Period {
        get {
            return this.read_Write_Loop_PeriodField;
        }
        set {
            this.read_Write_Loop_PeriodField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(typeof(ushort), "502")]
    public ushort TCP_Settings_Port {
        get {
            return this.tCP_Settings_PortField;
        }
        set {
            this.tCP_Settings_PortField = value;
        }
    }
    
    /// <remarks/>
    public string TCP_Settings_IP_Slave_Address {
        get {
            return this.tCP_Settings_IP_Slave_AddressField;
        }
        set {
            this.tCP_Settings_IP_Slave_AddressField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute(typeof(uint), "100")]
    public uint TCP_Settings_IP_Timeout {
        get {
            return this.tCP_Settings_IP_TimeoutField;
        }
        set {
            this.tCP_Settings_IP_TimeoutField = value;
        }
    }
    
    /// <remarks/>
    public string Serial_Settings_Resource_Name {
        get {
            return this.serial_Settings_Resource_NameField;
        }
        set {
            this.serial_Settings_Resource_NameField = value;
        }
    }
    
    /// <remarks/>
    public sbyte Serial_Settings_Unit_ID {
        get {
            return this.serial_Settings_Unit_IDField;
        }
        set {
            this.serial_Settings_Unit_IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Serial_Settings_Unit_IDSpecified {
        get {
            return this.serial_Settings_Unit_IDFieldSpecified;
        }
        set {
            this.serial_Settings_Unit_IDFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public Modbus_Custom_DeviceGeneral_SettingsSerial_Settings_Serial_Type Serial_Settings_Serial_Type {
        get {
            return this.serial_Settings_Serial_TypeField;
        }
        set {
            this.serial_Settings_Serial_TypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Serial_Settings_Serial_TypeSpecified {
        get {
            return this.serial_Settings_Serial_TypeFieldSpecified;
        }
        set {
            this.serial_Settings_Serial_TypeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint Serial_Settings_Baud_Rate {
        get {
            return this.serial_Settings_Baud_RateField;
        }
        set {
            this.serial_Settings_Baud_RateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Serial_Settings_Baud_RateSpecified {
        get {
            return this.serial_Settings_Baud_RateFieldSpecified;
        }
        set {
            this.serial_Settings_Baud_RateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public Modbus_Custom_DeviceGeneral_SettingsSerial_Settings_Parity Serial_Settings_Parity {
        get {
            return this.serial_Settings_ParityField;
        }
        set {
            this.serial_Settings_ParityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Serial_Settings_ParitySpecified {
        get {
            return this.serial_Settings_ParityFieldSpecified;
        }
        set {
            this.serial_Settings_ParityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public Modbus_Custom_DeviceGeneral_SettingsSerial_Settings_Flow_Control Serial_Settings_Flow_Control {
        get {
            return this.serial_Settings_Flow_ControlField;
        }
        set {
            this.serial_Settings_Flow_ControlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Serial_Settings_Flow_ControlSpecified {
        get {
            return this.serial_Settings_Flow_ControlFieldSpecified;
        }
        set {
            this.serial_Settings_Flow_ControlFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum Modbus_Custom_DeviceGeneral_SettingsModbus_Type {
    
    /// <remarks/>
    Undefined,
    
    /// <remarks/>
    Master,
    
    /// <remarks/>
    Slave,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum Modbus_Custom_DeviceGeneral_SettingsCommunication_Type {
    
    /// <remarks/>
    Undefined,
    
    /// <remarks/>
    TCP,
    
    /// <remarks/>
    Serial,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum Modbus_Custom_DeviceGeneral_SettingsSerial_Settings_Serial_Type {
    
    /// <remarks/>
    RTU,
    
    /// <remarks/>
    ASCII,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum Modbus_Custom_DeviceGeneral_SettingsSerial_Settings_Parity {
    
    /// <remarks/>
    None,
    
    /// <remarks/>
    Odd,
    
    /// <remarks/>
    Even,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum Modbus_Custom_DeviceGeneral_SettingsSerial_Settings_Flow_Control {
    
    /// <remarks/>
    None,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("XON/XOFF")]
    XONXOFF,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("RTS/CTS")]
    RTSCTS,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("XON/XOFF AND RTS/CTS")]
    XONXOFFANDRTSCTS,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("DTR/DSR")]
    DTRDSR,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("XON/XOFF AND DTR/DSR")]
    XONXOFFANDDTRDSR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceRead_Coils {
    
    private string base_NameField;
    
    private ushort starting_AddressField;
    
    private ushort quantityField;
    
    /// <remarks/>
    public string Base_Name {
        get {
            return this.base_NameField;
        }
        set {
            this.base_NameField = value;
        }
    }
    
    /// <remarks/>
    public ushort Starting_Address {
        get {
            return this.starting_AddressField;
        }
        set {
            this.starting_AddressField = value;
        }
    }
    
    /// <remarks/>
    public ushort Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceRead_Discrete_Inputs {
    
    private string base_NameField;
    
    private ushort starting_AddressField;
    
    private ushort quantityField;
    
    /// <remarks/>
    public string Base_Name {
        get {
            return this.base_NameField;
        }
        set {
            this.base_NameField = value;
        }
    }
    
    /// <remarks/>
    public ushort Starting_Address {
        get {
            return this.starting_AddressField;
        }
        set {
            this.starting_AddressField = value;
        }
    }
    
    /// <remarks/>
    public ushort Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceRead_Holding_Registers {
    
    private string base_NameField;
    
    private ushort starting_AddressField;
    
    private ushort quantityField;
    
    /// <remarks/>
    public string Base_Name {
        get {
            return this.base_NameField;
        }
        set {
            this.base_NameField = value;
        }
    }
    
    /// <remarks/>
    public ushort Starting_Address {
        get {
            return this.starting_AddressField;
        }
        set {
            this.starting_AddressField = value;
        }
    }
    
    /// <remarks/>
    public ushort Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceRead_Input_Registers {
    
    private string base_NameField;
    
    private ushort starting_AddressField;
    
    private ushort quantityField;
    
    /// <remarks/>
    public string Base_Name {
        get {
            return this.base_NameField;
        }
        set {
            this.base_NameField = value;
        }
    }
    
    /// <remarks/>
    public ushort Starting_Address {
        get {
            return this.starting_AddressField;
        }
        set {
            this.starting_AddressField = value;
        }
    }
    
    /// <remarks/>
    public ushort Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceWrite_Multiple_Coils {
    
    private string base_NameField;
    
    private ushort starting_AddressField;
    
    private ushort quantityField;
    
    /// <remarks/>
    public string Base_Name {
        get {
            return this.base_NameField;
        }
        set {
            this.base_NameField = value;
        }
    }
    
    /// <remarks/>
    public ushort Starting_Address {
        get {
            return this.starting_AddressField;
        }
        set {
            this.starting_AddressField = value;
        }
    }
    
    /// <remarks/>
    public ushort Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceWrite_Multiple_Discrete_Inputs {
    
    private string base_NameField;
    
    private ushort starting_AddressField;
    
    private ushort quantityField;
    
    /// <remarks/>
    public string Base_Name {
        get {
            return this.base_NameField;
        }
        set {
            this.base_NameField = value;
        }
    }
    
    /// <remarks/>
    public ushort Starting_Address {
        get {
            return this.starting_AddressField;
        }
        set {
            this.starting_AddressField = value;
        }
    }
    
    /// <remarks/>
    public ushort Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceWrite_Multiple_Registers {
    
    private string base_NameField;
    
    private ushort starting_AddressField;
    
    private ushort quantityField;
    
    /// <remarks/>
    public string Base_Name {
        get {
            return this.base_NameField;
        }
        set {
            this.base_NameField = value;
        }
    }
    
    /// <remarks/>
    public ushort Starting_Address {
        get {
            return this.starting_AddressField;
        }
        set {
            this.starting_AddressField = value;
        }
    }
    
    /// <remarks/>
    public ushort Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceWrite_Single_Coil {
    
    private string base_NameField;
    
    private ushort addressField;
    
    /// <remarks/>
    public string Base_Name {
        get {
            return this.base_NameField;
        }
        set {
            this.base_NameField = value;
        }
    }
    
    /// <remarks/>
    public ushort Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Modbus_Custom_DeviceWrite_Single_Register {
    
    private string base_NameField;
    
    private ushort addressField;
    
    /// <remarks/>
    public string Base_Name {
        get {
            return this.base_NameField;
        }
        set {
            this.base_NameField = value;
        }
    }
    
    /// <remarks/>
    public ushort Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
}
