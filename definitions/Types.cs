using System;
using System.Runtime.InteropServices;

namespace Epsilon.Types
{
    enum renderer_type
    {
        vulkan = 0,
        dx12,
        dx11,
        opengl,
        metal,
        size // if we ever want to iterate over renderer types
    };

    enum ShaderModuleStage
    {
        FRAGMENT = 0x1,
        VERTEX = 0x10,
        COMPUTE = 0x100,
        ALL = FRAGMENT | VERTEX | COMPUTE
    };
    enum TextureFormat
    {
        // INTEGER IMAGE
        COLOR_R = 0,
        COLOR_RG,
        COLOR_RGB,
        COLOR_RGBA,
        NON_COLOR_R,
        NON_COLOR_RG,
        NON_COLOR_RGB,
        NON_COLOR_RGBA,
        // FLOATING POINT IMAGE
        COLOR_R_16F,
        COLOR_R_32F,
        COLOR_RG_16F,
        COLOR_RG_32F,
        COLOR_RGB_16F,
        COLOR_RGB_32F,
        COLOR_RGBA_16F,
        COLOR_RGBA_32F,
        NON_COLOR_R_16F,
        NON_COLOR_R_32F,
        NON_COLOR_RG_16F,
        NON_COLOR_RG_32F,
        NON_COLOR_RGB_16F,
        NON_COLOR_RGB_32F,
        NON_COLOR_RGBA_16F,
        NON_COLOR_RGBA_32F,

        //DEPTH IMAGES
        DEPTH_F32,
        DEPTH_F32_STENCIL_8,
        DEPTH_F16,
        DEPTH_F16_STENCIL_8,

        DEPTH_UNORM,
        DEPTH_UNORM_STENCIL_8,
    };

    enum VertexFormat
    {
        XY_UINT,
        XY_FLOAT,
        XYZ_UINT,
        XYZ_FLOAT,
        XYZW_UINT,
        XYZW_FLOAT
    };

    enum CompareFunction
    {
        ALWAYS = 0,
        LESS,
        LESS_OR_EQUAL,
        EQUAL,
    };

    enum WrapMode
    {
        REPEAT = 0,
        CLAMP_TO_BORDER,
        CLAMP_TO_EDGE
    };

    enum Filtering
    {
        POINT = 0,
        LINEAR,
        ANISOTROPIC
    };

    enum WindingMode
    {
        CLOCKWISE = 0,
        COUNTER_CLOCK_WISE
    };

    enum CullMode
    {
        BACK = 0,
        FRONT,
        NONE
    };

    enum UniformBindingType
    {
        UNIFORM_BUFFER = 0,
        TEXTURE_SAMPLER,
        TEXTURE_IMAGE_COMBINED_SAMPLER,
        SHADER_STORAGE,
        BINDLESS_TEXTURE,
        ACCELERATION_STRUCTURE,
        STORAGE_IMAGE
    };

}