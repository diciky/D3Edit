// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Hireling.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace D3.Hireling {

  /// <summary>Holder for reflection information generated from Hireling.proto</summary>
  public static partial class HirelingReflection {

    #region Descriptor
    /// <summary>File descriptor for Hireling.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HirelingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5IaXJlbGluZy5wcm90bxILRDMuSGlyZWxpbmcioQEKBEluZm8SFgoOaGly",
            "ZWxpbmdfY2xhc3MYASABKBESEQoJZ2JpZF9uYW1lGAIgASgPEhgKEGxldmVs",
            "X2RlcHJlY2F0ZWQYAyABKBESLAokYXR0cmlidXRlX2V4cGVyaWVuY2VfbmV4",
            "dF9kZXByZWNhdGVkGAQgASgNEhgKEHBvd2VyX2tleV9wYXJhbXMYBSADKBES",
            "DAoEZGVhZBgGIAEoCCJwCglTYXZlZERhdGESJAoJaGlyZWxpbmdzGAEgAygL",
            "MhEuRDMuSGlyZWxpbmcuSW5mbxIXCg9hY3RpdmVfaGlyZWxpbmcYAiABKA0S",
            "JAocYXZhaWxhYmxlX2hpcmVsaW5nc19iaXRmaWVsZBgDIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::D3.Hireling.Info), global::D3.Hireling.Info.Parser, new[]{ "HirelingClass", "GbidName", "LevelDeprecated", "AttributeExperienceNextDeprecated", "PowerKeyParams", "Dead" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::D3.Hireling.SavedData), global::D3.Hireling.SavedData.Parser, new[]{ "Hirelings", "ActiveHireling", "AvailableHirelingsBitfield" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Info : pb::IMessage<Info> {
    private static readonly pb::MessageParser<Info> _parser = new pb::MessageParser<Info>(() => new Info());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Info> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::D3.Hireling.HirelingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Info() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Info(Info other) : this() {
      hirelingClass_ = other.hirelingClass_;
      gbidName_ = other.gbidName_;
      levelDeprecated_ = other.levelDeprecated_;
      attributeExperienceNextDeprecated_ = other.attributeExperienceNextDeprecated_;
      powerKeyParams_ = other.powerKeyParams_.Clone();
      dead_ = other.dead_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Info Clone() {
      return new Info(this);
    }

    /// <summary>Field number for the "hireling_class" field.</summary>
    public const int HirelingClassFieldNumber = 1;
    private int hirelingClass_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int HirelingClass {
      get { return hirelingClass_; }
      set {
        hirelingClass_ = value;
      }
    }

    /// <summary>Field number for the "gbid_name" field.</summary>
    public const int GbidNameFieldNumber = 2;
    private int gbidName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GbidName {
      get { return gbidName_; }
      set {
        gbidName_ = value;
      }
    }

    /// <summary>Field number for the "level_deprecated" field.</summary>
    public const int LevelDeprecatedFieldNumber = 3;
    private int levelDeprecated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LevelDeprecated {
      get { return levelDeprecated_; }
      set {
        levelDeprecated_ = value;
      }
    }

    /// <summary>Field number for the "attribute_experience_next_deprecated" field.</summary>
    public const int AttributeExperienceNextDeprecatedFieldNumber = 4;
    private uint attributeExperienceNextDeprecated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint AttributeExperienceNextDeprecated {
      get { return attributeExperienceNextDeprecated_; }
      set {
        attributeExperienceNextDeprecated_ = value;
      }
    }

    /// <summary>Field number for the "power_key_params" field.</summary>
    public const int PowerKeyParamsFieldNumber = 5;
    private static readonly pb::FieldCodec<int> _repeated_powerKeyParams_codec
        = pb::FieldCodec.ForSInt32(42);
    private readonly pbc::RepeatedField<int> powerKeyParams_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> PowerKeyParams {
      get { return powerKeyParams_; }
    }

    /// <summary>Field number for the "dead" field.</summary>
    public const int DeadFieldNumber = 6;
    private bool dead_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Dead {
      get { return dead_; }
      set {
        dead_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Info);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Info other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HirelingClass != other.HirelingClass) return false;
      if (GbidName != other.GbidName) return false;
      if (LevelDeprecated != other.LevelDeprecated) return false;
      if (AttributeExperienceNextDeprecated != other.AttributeExperienceNextDeprecated) return false;
      if(!powerKeyParams_.Equals(other.powerKeyParams_)) return false;
      if (Dead != other.Dead) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HirelingClass != 0) hash ^= HirelingClass.GetHashCode();
      if (GbidName != 0) hash ^= GbidName.GetHashCode();
      if (LevelDeprecated != 0) hash ^= LevelDeprecated.GetHashCode();
      if (AttributeExperienceNextDeprecated != 0) hash ^= AttributeExperienceNextDeprecated.GetHashCode();
      hash ^= powerKeyParams_.GetHashCode();
      if (Dead != false) hash ^= Dead.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HirelingClass != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(HirelingClass);
      }
      if (GbidName != 0) {
        output.WriteRawTag(21);
        output.WriteSFixed32(GbidName);
      }
      if (LevelDeprecated != 0) {
        output.WriteRawTag(24);
        output.WriteSInt32(LevelDeprecated);
      }
      if (AttributeExperienceNextDeprecated != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AttributeExperienceNextDeprecated);
      }
      powerKeyParams_.WriteTo(output, _repeated_powerKeyParams_codec);
      if (Dead != false) {
        output.WriteRawTag(48);
        output.WriteBool(Dead);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HirelingClass != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(HirelingClass);
      }
      if (GbidName != 0) {
        size += 1 + 4;
      }
      if (LevelDeprecated != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(LevelDeprecated);
      }
      if (AttributeExperienceNextDeprecated != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AttributeExperienceNextDeprecated);
      }
      size += powerKeyParams_.CalculateSize(_repeated_powerKeyParams_codec);
      if (Dead != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Info other) {
      if (other == null) {
        return;
      }
      if (other.HirelingClass != 0) {
        HirelingClass = other.HirelingClass;
      }
      if (other.GbidName != 0) {
        GbidName = other.GbidName;
      }
      if (other.LevelDeprecated != 0) {
        LevelDeprecated = other.LevelDeprecated;
      }
      if (other.AttributeExperienceNextDeprecated != 0) {
        AttributeExperienceNextDeprecated = other.AttributeExperienceNextDeprecated;
      }
      powerKeyParams_.Add(other.powerKeyParams_);
      if (other.Dead != false) {
        Dead = other.Dead;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            HirelingClass = input.ReadSInt32();
            break;
          }
          case 21: {
            GbidName = input.ReadSFixed32();
            break;
          }
          case 24: {
            LevelDeprecated = input.ReadSInt32();
            break;
          }
          case 32: {
            AttributeExperienceNextDeprecated = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            powerKeyParams_.AddEntriesFrom(input, _repeated_powerKeyParams_codec);
            break;
          }
          case 48: {
            Dead = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SavedData : pb::IMessage<SavedData> {
    private static readonly pb::MessageParser<SavedData> _parser = new pb::MessageParser<SavedData>(() => new SavedData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SavedData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::D3.Hireling.HirelingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavedData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavedData(SavedData other) : this() {
      hirelings_ = other.hirelings_.Clone();
      activeHireling_ = other.activeHireling_;
      availableHirelingsBitfield_ = other.availableHirelingsBitfield_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SavedData Clone() {
      return new SavedData(this);
    }

    /// <summary>Field number for the "hirelings" field.</summary>
    public const int HirelingsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::D3.Hireling.Info> _repeated_hirelings_codec
        = pb::FieldCodec.ForMessage(10, global::D3.Hireling.Info.Parser);
    private readonly pbc::RepeatedField<global::D3.Hireling.Info> hirelings_ = new pbc::RepeatedField<global::D3.Hireling.Info>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::D3.Hireling.Info> Hirelings {
      get { return hirelings_; }
    }

    /// <summary>Field number for the "active_hireling" field.</summary>
    public const int ActiveHirelingFieldNumber = 2;
    private uint activeHireling_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ActiveHireling {
      get { return activeHireling_; }
      set {
        activeHireling_ = value;
      }
    }

    /// <summary>Field number for the "available_hirelings_bitfield" field.</summary>
    public const int AvailableHirelingsBitfieldFieldNumber = 3;
    private uint availableHirelingsBitfield_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint AvailableHirelingsBitfield {
      get { return availableHirelingsBitfield_; }
      set {
        availableHirelingsBitfield_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SavedData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SavedData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!hirelings_.Equals(other.hirelings_)) return false;
      if (ActiveHireling != other.ActiveHireling) return false;
      if (AvailableHirelingsBitfield != other.AvailableHirelingsBitfield) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= hirelings_.GetHashCode();
      if (ActiveHireling != 0) hash ^= ActiveHireling.GetHashCode();
      if (AvailableHirelingsBitfield != 0) hash ^= AvailableHirelingsBitfield.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      hirelings_.WriteTo(output, _repeated_hirelings_codec);
      if (ActiveHireling != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ActiveHireling);
      }
      if (AvailableHirelingsBitfield != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(AvailableHirelingsBitfield);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += hirelings_.CalculateSize(_repeated_hirelings_codec);
      if (ActiveHireling != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActiveHireling);
      }
      if (AvailableHirelingsBitfield != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvailableHirelingsBitfield);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SavedData other) {
      if (other == null) {
        return;
      }
      hirelings_.Add(other.hirelings_);
      if (other.ActiveHireling != 0) {
        ActiveHireling = other.ActiveHireling;
      }
      if (other.AvailableHirelingsBitfield != 0) {
        AvailableHirelingsBitfield = other.AvailableHirelingsBitfield;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            hirelings_.AddEntriesFrom(input, _repeated_hirelings_codec);
            break;
          }
          case 16: {
            ActiveHireling = input.ReadUInt32();
            break;
          }
          case 24: {
            AvailableHirelingsBitfield = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
