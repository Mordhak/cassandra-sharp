/**
 * Autogenerated by Thrift Compiler (0.9.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Apache.Cassandra
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class KsDef : TBase
  {
    private string _name;
    private string _strategy_class;
    private Dictionary<string, string> _strategy_options;
    private int _replication_factor;
    private List<CfDef> _cf_defs;
    private bool _durable_writes;

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public string Strategy_class
    {
      get
      {
        return _strategy_class;
      }
      set
      {
        __isset.strategy_class = true;
        this._strategy_class = value;
      }
    }

    public Dictionary<string, string> Strategy_options
    {
      get
      {
        return _strategy_options;
      }
      set
      {
        __isset.strategy_options = true;
        this._strategy_options = value;
      }
    }

    /// <summary>
    /// @deprecated ignored
    /// </summary>
    public int Replication_factor
    {
      get
      {
        return _replication_factor;
      }
      set
      {
        __isset.replication_factor = true;
        this._replication_factor = value;
      }
    }

    public List<CfDef> Cf_defs
    {
      get
      {
        return _cf_defs;
      }
      set
      {
        __isset.cf_defs = true;
        this._cf_defs = value;
      }
    }

    public bool Durable_writes
    {
      get
      {
        return _durable_writes;
      }
      set
      {
        __isset.durable_writes = true;
        this._durable_writes = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool name;
      public bool strategy_class;
      public bool strategy_options;
      public bool replication_factor;
      public bool cf_defs;
      public bool durable_writes;
    }

    public KsDef() {
      this._durable_writes = true;
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Strategy_class = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Map) {
              {
                Strategy_options = new Dictionary<string, string>();
                TMap _map60 = iprot.ReadMapBegin();
                for( int _i61 = 0; _i61 < _map60.Count; ++_i61)
                {
                  string _key62;
                  string _val63;
                  _key62 = iprot.ReadString();
                  _val63 = iprot.ReadString();
                  Strategy_options[_key62] = _val63;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Replication_factor = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                Cf_defs = new List<CfDef>();
                TList _list64 = iprot.ReadListBegin();
                for( int _i65 = 0; _i65 < _list64.Count; ++_i65)
                {
                  CfDef _elem66 = new CfDef();
                  _elem66 = new CfDef();
                  _elem66.Read(iprot);
                  Cf_defs.Add(_elem66);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Bool) {
              Durable_writes = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("KsDef");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (Strategy_class != null && __isset.strategy_class) {
        field.Name = "strategy_class";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Strategy_class);
        oprot.WriteFieldEnd();
      }
      if (Strategy_options != null && __isset.strategy_options) {
        field.Name = "strategy_options";
        field.Type = TType.Map;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.String, Strategy_options.Count));
          foreach (string _iter67 in Strategy_options.Keys)
          {
            oprot.WriteString(_iter67);
            oprot.WriteString(Strategy_options[_iter67]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.replication_factor) {
        field.Name = "replication_factor";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Replication_factor);
        oprot.WriteFieldEnd();
      }
      if (Cf_defs != null && __isset.cf_defs) {
        field.Name = "cf_defs";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Cf_defs.Count));
          foreach (CfDef _iter68 in Cf_defs)
          {
            _iter68.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.durable_writes) {
        field.Name = "durable_writes";
        field.Type = TType.Bool;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Durable_writes);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("KsDef(");
      sb.Append("Name: ");
      sb.Append(Name);
      sb.Append(",Strategy_class: ");
      sb.Append(Strategy_class);
      sb.Append(",Strategy_options: ");
      sb.Append(Strategy_options);
      sb.Append(",Replication_factor: ");
      sb.Append(Replication_factor);
      sb.Append(",Cf_defs: ");
      sb.Append(Cf_defs);
      sb.Append(",Durable_writes: ");
      sb.Append(Durable_writes);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
