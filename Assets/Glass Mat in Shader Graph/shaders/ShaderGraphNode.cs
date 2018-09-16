using UnityEngine;
using UnityEditor.ShaderGraph;
using System.Reflection;
[Title("Custom", "Refraction")]
	public class ShaderGraphNode : CodeFunctionNode
{
	public ShaderGraphNode()
	{
		name = "Refraction";
	}

	protected override MethodInfo GetFunctionToConvert()
	{
		return GetType().GetMethod("MyCustomFunction",
			BindingFlags.Static | BindingFlags.NonPublic);
	}
	static string MyCustomFunction(
		[Slot(0, Binding.None)] Vector1 IOR,
		[Slot(1, Binding.None)] Vector3 ViewDirection,
		[Slot(2, Binding.None)] Vector3 NormalDirection,
		[Slot(3, Binding.None)] out Vector3 Out)
	{
		Out = Vector3.zero;
		return
			@"
{
	Out = refract(normalize(ViewDirection), normalize(NormalDirection), IOR);
} 
";
	}


}