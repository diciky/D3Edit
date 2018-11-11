# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ItemCrafting.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import GameBalance_pb2 as GameBalance__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='ItemCrafting.proto',
  package='D3.ItemCrafting',
  syntax='proto2',
  serialized_options=None,
  serialized_pb=_b('\n\x12ItemCrafting.proto\x12\x0f\x44\x33.ItemCrafting\x1a\x11GameBalance.proto\"\xa9\x01\n\x0b\x43rafterData\x12\x0f\n\x07recipes\x18\x01 \x03(\x0f\x12%\n\x1d\x64\x65precated_available_enchants\x18\x02 \x03(\x0f\x12\r\n\x05level\x18\x03 \x02(\x05\x12\x14\n\x0c\x63ooldown_end\x18\x04 \x01(\x10\x12\x18\n\x10recipes_bitfield\x18\x05 \x01(\x0c\x12#\n\x1b\x62itfield_leading_null_bytes\x18\x06 \x01(\x05\".\n\x15\x43rafterDevilsHandData\x12\x15\n\runlocked_sets\x18\x01 \x03(\x0f\"\x96\x02\n\x10\x43rafterSavedData\x12\x32\n\x0c\x63rafter_data\x18\x01 \x03(\x0b\x32\x1c.D3.ItemCrafting.CrafterData\x12\x39\n\rtransmog_data\x18\x02 \x01(\x0b\x32\".D3.GameBalance.BitPackedGbidArray\x12K\n\x1b\x64\x65precated_devils_hand_data\x18\x03 \x01(\x0b\x32&.D3.ItemCrafting.CrafterDevilsHandData\x12\x46\n\x1a\x65xtracted_legendaries_data\x18\x04 \x01(\x0b\x32\".D3.GameBalance.BitPackedGbidArray')
  ,
  dependencies=[GameBalance__pb2.DESCRIPTOR,])




_CRAFTERDATA = _descriptor.Descriptor(
  name='CrafterData',
  full_name='D3.ItemCrafting.CrafterData',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='recipes', full_name='D3.ItemCrafting.CrafterData.recipes', index=0,
      number=1, type=15, cpp_type=1, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='deprecated_available_enchants', full_name='D3.ItemCrafting.CrafterData.deprecated_available_enchants', index=1,
      number=2, type=15, cpp_type=1, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='level', full_name='D3.ItemCrafting.CrafterData.level', index=2,
      number=3, type=5, cpp_type=1, label=2,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='cooldown_end', full_name='D3.ItemCrafting.CrafterData.cooldown_end', index=3,
      number=4, type=16, cpp_type=2, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='recipes_bitfield', full_name='D3.ItemCrafting.CrafterData.recipes_bitfield', index=4,
      number=5, type=12, cpp_type=9, label=1,
      has_default_value=False, default_value=_b(""),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='bitfield_leading_null_bytes', full_name='D3.ItemCrafting.CrafterData.bitfield_leading_null_bytes', index=5,
      number=6, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=59,
  serialized_end=228,
)


_CRAFTERDEVILSHANDDATA = _descriptor.Descriptor(
  name='CrafterDevilsHandData',
  full_name='D3.ItemCrafting.CrafterDevilsHandData',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='unlocked_sets', full_name='D3.ItemCrafting.CrafterDevilsHandData.unlocked_sets', index=0,
      number=1, type=15, cpp_type=1, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=230,
  serialized_end=276,
)


_CRAFTERSAVEDDATA = _descriptor.Descriptor(
  name='CrafterSavedData',
  full_name='D3.ItemCrafting.CrafterSavedData',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='crafter_data', full_name='D3.ItemCrafting.CrafterSavedData.crafter_data', index=0,
      number=1, type=11, cpp_type=10, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='transmog_data', full_name='D3.ItemCrafting.CrafterSavedData.transmog_data', index=1,
      number=2, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='deprecated_devils_hand_data', full_name='D3.ItemCrafting.CrafterSavedData.deprecated_devils_hand_data', index=2,
      number=3, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='extracted_legendaries_data', full_name='D3.ItemCrafting.CrafterSavedData.extracted_legendaries_data', index=3,
      number=4, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=279,
  serialized_end=557,
)

_CRAFTERSAVEDDATA.fields_by_name['crafter_data'].message_type = _CRAFTERDATA
_CRAFTERSAVEDDATA.fields_by_name['transmog_data'].message_type = GameBalance__pb2._BITPACKEDGBIDARRAY
_CRAFTERSAVEDDATA.fields_by_name['deprecated_devils_hand_data'].message_type = _CRAFTERDEVILSHANDDATA
_CRAFTERSAVEDDATA.fields_by_name['extracted_legendaries_data'].message_type = GameBalance__pb2._BITPACKEDGBIDARRAY
DESCRIPTOR.message_types_by_name['CrafterData'] = _CRAFTERDATA
DESCRIPTOR.message_types_by_name['CrafterDevilsHandData'] = _CRAFTERDEVILSHANDDATA
DESCRIPTOR.message_types_by_name['CrafterSavedData'] = _CRAFTERSAVEDDATA
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

CrafterData = _reflection.GeneratedProtocolMessageType('CrafterData', (_message.Message,), dict(
  DESCRIPTOR = _CRAFTERDATA,
  __module__ = 'ItemCrafting_pb2'
  # @@protoc_insertion_point(class_scope:D3.ItemCrafting.CrafterData)
  ))
_sym_db.RegisterMessage(CrafterData)

CrafterDevilsHandData = _reflection.GeneratedProtocolMessageType('CrafterDevilsHandData', (_message.Message,), dict(
  DESCRIPTOR = _CRAFTERDEVILSHANDDATA,
  __module__ = 'ItemCrafting_pb2'
  # @@protoc_insertion_point(class_scope:D3.ItemCrafting.CrafterDevilsHandData)
  ))
_sym_db.RegisterMessage(CrafterDevilsHandData)

CrafterSavedData = _reflection.GeneratedProtocolMessageType('CrafterSavedData', (_message.Message,), dict(
  DESCRIPTOR = _CRAFTERSAVEDDATA,
  __module__ = 'ItemCrafting_pb2'
  # @@protoc_insertion_point(class_scope:D3.ItemCrafting.CrafterSavedData)
  ))
_sym_db.RegisterMessage(CrafterSavedData)


# @@protoc_insertion_point(module_scope)
