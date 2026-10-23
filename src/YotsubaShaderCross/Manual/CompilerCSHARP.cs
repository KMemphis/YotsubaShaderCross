namespace YotsubaShaderCross;

public partial class CompilerCSHARP : CompilerGLSL
{
    
    public CompilerCSHARP(CppVector<uint> spirv_) : base(spirv_)
    {
        throw new NotImplementedException();
    }
    
    public CompilerCSHARP(Ptr<uint> ir_, ulong size) : base(ir_, size)
    {
        throw new NotImplementedException();
    }
    
    public CompilerCSHARP(ParsedIR ir_) : base(ir_)
    {
        throw new NotImplementedException();
    }
    
}