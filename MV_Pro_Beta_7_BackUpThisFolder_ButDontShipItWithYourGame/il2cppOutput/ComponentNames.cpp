#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Collections.Concurrent.ConcurrentDictionary`2<UnityEngine.Component,Sisus.ComponentNames.EditorOnly.NameContainer>
struct ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092;
// System.Collections.Concurrent.ConcurrentDictionary`2<System.Object,System.Object>
struct ConcurrentDictionary_2_tF598E45B2A3ECB23FD311D829FB0AB32B1201ACF;
// System.Collections.Generic.IEqualityComparer`1<UnityEngine.Component>
struct IEqualityComparer_1_t5F1247344658B7771C2EFA9A56F3195BF2EFD422;
// System.Collections.Concurrent.ConcurrentDictionary`2/Tables<UnityEngine.Component,Sisus.ComponentNames.EditorOnly.NameContainer>
struct Tables_tECFF1B8598E07EBEC4D21AEB0D7A363A3754424A;
// System.Collections.Generic.KeyValuePair`2<UnityEngine.Component,Sisus.ComponentNames.EditorOnly.NameContainer>[]
struct KeyValuePair_2U5BU5D_t9F095EE4333EFCC4953F95284B94ABD91E7E12F2;
// System.Type[]
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB;
// Sisus.ComponentNames.BaseBehaviour
struct BaseBehaviour_tEA7B1D7864FFED61B005B7F423743C719B64D29B;
// System.Reflection.Binder
struct Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235;
// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3;
// UnityEngine.GUIContent
struct GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2;
// System.Reflection.MemberFilter
struct MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71;
// Sisus.ComponentNames.EditorOnly.NameContainer
struct NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883;
// System.String
struct String_t;
// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700;
// System.Type
struct Type_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;

IL2CPP_EXTERN_C RuntimeClass* ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C const RuntimeMethod* ConcurrentDictionary_2__ctor_mDC6A94BAD44A1C743E7351B628F01BE6784A9632_RuntimeMethod_var;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tBC2C8B6D81F2D0E61B651D4622F6A5E60706415A 
{
};

// System.Collections.Concurrent.ConcurrentDictionary`2<UnityEngine.Component,Sisus.ComponentNames.EditorOnly.NameContainer>
struct ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092  : public RuntimeObject
{
	// System.Collections.Concurrent.ConcurrentDictionary`2/Tables<TKey,TValue> modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Concurrent.ConcurrentDictionary`2::_tables
	Tables_tECFF1B8598E07EBEC4D21AEB0D7A363A3754424A* ____tables_0;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Concurrent.ConcurrentDictionary`2::_comparer
	RuntimeObject* ____comparer_1;
	// System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2::_growLockArray
	bool ____growLockArray_2;
	// System.Int32 System.Collections.Concurrent.ConcurrentDictionary`2::_budget
	int32_t ____budget_3;
	// System.Collections.Generic.KeyValuePair`2<TKey,TValue>[] System.Collections.Concurrent.ConcurrentDictionary`2::_serializationArray
	KeyValuePair_2U5BU5D_t9F095EE4333EFCC4953F95284B94ABD91E7E12F2* ____serializationArray_4;
	// System.Int32 System.Collections.Concurrent.ConcurrentDictionary`2::_serializationConcurrencyLevel
	int32_t ____serializationConcurrencyLevel_5;
	// System.Int32 System.Collections.Concurrent.ConcurrentDictionary`2::_serializationCapacity
	int32_t ____serializationCapacity_6;
};

// Sisus.ComponentNames.ComponentExtensions
struct ComponentExtensions_t859C479545BAB3F89BE44DFE0B5C59BEC9673BC2  : public RuntimeObject
{
};

// UnityEngine.GUIContent
struct GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2  : public RuntimeObject
{
	// System.String UnityEngine.GUIContent::m_Text
	String_t* ___m_Text_0;
	// UnityEngine.Texture UnityEngine.GUIContent::m_Image
	Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___m_Image_1;
	// System.String UnityEngine.GUIContent::m_Tooltip
	String_t* ___m_Tooltip_2;
};
// Native definition for P/Invoke marshalling of UnityEngine.GUIContent
struct GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2_marshaled_pinvoke
{
	char* ___m_Text_0;
	Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___m_Image_1;
	char* ___m_Tooltip_2;
};
// Native definition for COM marshalling of UnityEngine.GUIContent
struct GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2_marshaled_com
{
	Il2CppChar* ___m_Text_0;
	Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* ___m_Image_1;
	Il2CppChar* ___m_Tooltip_2;
};

// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// System.RuntimeTypeHandle
struct RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B 
{
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.Type
struct Type_t  : public MemberInfo_t
{
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ____impl_8;
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// Sisus.ComponentNames.BaseBehaviour
struct BaseBehaviour_tEA7B1D7864FFED61B005B7F423743C719B64D29B  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// Sisus.ComponentNames.EditorOnly.NameContainer
struct NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// System.String Sisus.ComponentNames.EditorOnly.NameContainer::nameOverride
	String_t* ___nameOverride_8;
	// System.String Sisus.ComponentNames.EditorOnly.NameContainer::tooltipOverride
	String_t* ___tooltipOverride_9;
	// UnityEngine.Component Sisus.ComponentNames.EditorOnly.NameContainer::target
	Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___target_10;
};

// <Module>

// <Module>

// System.Collections.Concurrent.ConcurrentDictionary`2<UnityEngine.Component,Sisus.ComponentNames.EditorOnly.NameContainer>
struct ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092_StaticFields
{
	// System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2::s_isValueWriteAtomic
	bool ___s_isValueWriteAtomic_9;
};

// System.Collections.Concurrent.ConcurrentDictionary`2<UnityEngine.Component,Sisus.ComponentNames.EditorOnly.NameContainer>

// Sisus.ComponentNames.ComponentExtensions

// Sisus.ComponentNames.ComponentExtensions

// UnityEngine.GUIContent
struct GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2_StaticFields
{
	// UnityEngine.GUIContent UnityEngine.GUIContent::s_Text
	GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2* ___s_Text_3;
	// UnityEngine.GUIContent UnityEngine.GUIContent::s_Image
	GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2* ___s_Image_4;
	// UnityEngine.GUIContent UnityEngine.GUIContent::s_TextImage
	GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2* ___s_TextImage_5;
	// UnityEngine.GUIContent UnityEngine.GUIContent::none
	GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2* ___none_6;
};

// UnityEngine.GUIContent

// System.Reflection.MemberInfo

// System.Reflection.MemberInfo

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// System.ValueType

// System.ValueType

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// System.IntPtr
struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.IntPtr

// System.Void

// System.Void

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};

// UnityEngine.Object

// System.RuntimeTypeHandle

// System.RuntimeTypeHandle

// UnityEngine.Component

// UnityEngine.Component

// System.Type
struct Type_t_StaticFields
{
	// System.Reflection.Binder modreq(System.Runtime.CompilerServices.IsVolatile) System.Type::s_defaultBinder
	Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235* ___s_defaultBinder_0;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_1;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___EmptyTypes_2;
	// System.Object System.Type::Missing
	RuntimeObject* ___Missing_3;
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterAttribute_4;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterName_5;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterNameIgnoreCase_6;
};

// System.Type

// UnityEngine.Behaviour

// UnityEngine.Behaviour

// UnityEngine.MonoBehaviour

// UnityEngine.MonoBehaviour

// Sisus.ComponentNames.BaseBehaviour

// Sisus.ComponentNames.BaseBehaviour

// Sisus.ComponentNames.EditorOnly.NameContainer
struct NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883_StaticFields
{
	// System.Boolean Sisus.ComponentNames.EditorOnly.NameContainer::NowRenaming
	bool ___NowRenaming_5;
	// UnityEngine.Component Sisus.ComponentNames.EditorOnly.NameContainer::StartingToRename
	Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___StartingToRename_6;
	// System.Collections.Concurrent.ConcurrentDictionary`2<UnityEngine.Component,Sisus.ComponentNames.EditorOnly.NameContainer> Sisus.ComponentNames.EditorOnly.NameContainer::instances
	ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092* ___instances_7;
};

// Sisus.ComponentNames.EditorOnly.NameContainer
#ifdef __clang__
#pragma clang diagnostic pop
#endif


// System.Void System.Collections.Concurrent.ConcurrentDictionary`2<System.Object,System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConcurrentDictionary_2__ctor_m0891574E19148D39C27C179BF2787093757C5F57_gshared (ConcurrentDictionary_2_tF598E45B2A3ECB23FD311D829FB0AB32B1201ACF* __this, const RuntimeMethod* method) ;

// System.String Sisus.ComponentNames.ComponentExtensions::GetName(UnityEngine.Component)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ComponentExtensions_GetName_m5037F767FDF81FFFCBF450128D2CBF13300F4B75 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___0_component, const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, const RuntimeMethod* method) ;
// System.Type System.Object::GetType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t* Object_GetType_mE10A8FC1E57F3DF29972CCBC026C2DC3942263B3 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Concurrent.ConcurrentDictionary`2<UnityEngine.Component,Sisus.ComponentNames.EditorOnly.NameContainer>::.ctor()
inline void ConcurrentDictionary_2__ctor_mDC6A94BAD44A1C743E7351B628F01BE6784A9632 (ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092* __this, const RuntimeMethod* method)
{
	((  void (*) (ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092*, const RuntimeMethod*))ConcurrentDictionary_2__ctor_m0891574E19148D39C27C179BF2787093757C5F57_gshared)(__this, method);
}
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.String Sisus.ComponentNames.BaseBehaviour::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BaseBehaviour_get_name_m33D03A0C43A13DB84FF1787DD22A7E9DEF1B98D4 (BaseBehaviour_tEA7B1D7864FFED61B005B7F423743C719B64D29B* __this, const RuntimeMethod* method) 
{
	{
		// get => this.GetName();
		String_t* L_0;
		L_0 = ComponentExtensions_GetName_m5037F767FDF81FFFCBF450128D2CBF13300F4B75(__this, NULL);
		return L_0;
	}
}
// System.Void Sisus.ComponentNames.BaseBehaviour::set_name(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BaseBehaviour_set_name_m084189CFAD1447BDD26D31623E2B6B9E6012EEFE (BaseBehaviour_tEA7B1D7864FFED61B005B7F423743C719B64D29B* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.String Sisus.ComponentNames.BaseBehaviour::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BaseBehaviour_ToString_m9CD674CE66E645DADE673A27E0EC053B8B8BAAE4 (BaseBehaviour_tEA7B1D7864FFED61B005B7F423743C719B64D29B* __this, const RuntimeMethod* method) 
{
	{
		// public override string ToString() => this.GetName();
		String_t* L_0;
		L_0 = ComponentExtensions_GetName_m5037F767FDF81FFFCBF450128D2CBF13300F4B75(__this, NULL);
		return L_0;
	}
}
// System.Void Sisus.ComponentNames.BaseBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BaseBehaviour__ctor_m52BA602CB3726651AFA9F496ADC8598036752CB9 (BaseBehaviour_tEA7B1D7864FFED61B005B7F423743C719B64D29B* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.String Sisus.ComponentNames.ComponentExtensions::GetName(UnityEngine.Component)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ComponentExtensions_GetName_m5037F767FDF81FFFCBF450128D2CBF13300F4B75 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___0_component, const RuntimeMethod* method) 
{
	{
		// return component.GetType().Name;
		Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* L_0 = ___0_component;
		NullCheck(L_0);
		Type_t* L_1;
		L_1 = Object_GetType_mE10A8FC1E57F3DF29972CCBC026C2DC3942263B3(L_0, NULL);
		NullCheck(L_1);
		String_t* L_2;
		L_2 = VirtualFuncInvoker0< String_t* >::Invoke(7 /* System.String System.Reflection.MemberInfo::get_Name() */, L_1);
		return L_2;
	}
}
// System.Void Sisus.ComponentNames.ComponentExtensions::SetName(UnityEngine.Component,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ComponentExtensions_SetName_m2D58FD433EDAC5414C28A202B8E9CDF271516AE2 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___0_component, String_t* ___1_name, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void Sisus.ComponentNames.ComponentExtensions::SetName(UnityEngine.Component,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ComponentExtensions_SetName_mDDC8EF2C0DD7ACAB3B28E6918F595AAF38166AF9 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___0_component, String_t* ___1_name, bool ___2_classNameSuffix, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void Sisus.ComponentNames.ComponentExtensions::SetName(UnityEngine.Component,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ComponentExtensions_SetName_m41C5D874029039D9DB1EC22A3A795711A753D2BC (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___0_component, String_t* ___1_name, String_t* ___2_suffix, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void Sisus.ComponentNames.ComponentExtensions::SetName(UnityEngine.Component,UnityEngine.GUIContent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ComponentExtensions_SetName_m2AA0216ED936664C9A38DC1123A0F8FDEB6C5E56 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___0_component, GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2* ___1_nameAndTooltip, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void Sisus.ComponentNames.ComponentExtensions::SetName(UnityEngine.Component,UnityEngine.GUIContent,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ComponentExtensions_SetName_mC99CDB417B0BC586FE1D4C60CE84269BF9976D66 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___0_component, GUIContent_t15E48D4BEB1E6B6044F7DEB5E350800F511C2ED2* ___1_nameAndTooltip, bool ___2_classNameSuffix, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void Sisus.ComponentNames.ComponentExtensions::SetName(UnityEngine.Component,System.String,System.Boolean,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ComponentExtensions_SetName_m6BE2F9B7919EBB329E4C3EBE73AA8CB5F86AB9AA (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___0_component, String_t* ___1_name, bool ___2_classNameSuffix, String_t* ___3_tooltip, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void Sisus.ComponentNames.ComponentExtensions::SetName(UnityEngine.Component,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ComponentExtensions_SetName_m2B926E955C8E37DA45C835D2621EB3521A82A9FB (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* ___0_component, String_t* ___1_name, String_t* ___2_suffix, String_t* ___3_tooltip, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Sisus.ComponentNames.EditorOnly.NameContainer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NameContainer__ctor_mF4A1BC49368541E90E6AFBA29FD6DCD78747F01C (NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private string nameOverride = "";
		__this->___nameOverride_8 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___nameOverride_8), (void*)_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		// private string tooltipOverride = "";
		__this->___tooltipOverride_9 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___tooltipOverride_9), (void*)_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
// System.Void Sisus.ComponentNames.EditorOnly.NameContainer::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NameContainer__cctor_mE3670524FC4C302685AC5C3C0C0CEE1AE10C39A4 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2__ctor_mDC6A94BAD44A1C743E7351B628F01BE6784A9632_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private static readonly ConcurrentDictionary<Component, NameContainer> instances = new ConcurrentDictionary<Component, NameContainer>();
		ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092* L_0 = (ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092*)il2cpp_codegen_object_new(ConcurrentDictionary_2_tC721E255682E4B11019022B042A2130A6F6BA092_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		ConcurrentDictionary_2__ctor_mDC6A94BAD44A1C743E7351B628F01BE6784A9632(L_0, ConcurrentDictionary_2__ctor_mDC6A94BAD44A1C743E7351B628F01BE6784A9632_RuntimeMethod_var);
		((NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883_StaticFields*)il2cpp_codegen_static_fields_for(NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883_il2cpp_TypeInfo_var))->___instances_7 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883_StaticFields*)il2cpp_codegen_static_fields_for(NameContainer_t0850D02997085FCDE9B8AA985CB977DE78B6C883_il2cpp_TypeInfo_var))->___instances_7), (void*)L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
