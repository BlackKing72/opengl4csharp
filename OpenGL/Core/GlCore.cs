using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace OpenGL
{
    partial class Gl
    {
        internal static partial class NativeMethods
        {
            [LibraryImport(Gl.Library, EntryPoint = "glActiveShaderProgram")]
            internal static partial void ActiveShaderProgram(UInt32 pipeline, UInt32 program);
            [LibraryImport(Gl.Library, EntryPoint = "glActiveTexture")]
            internal static partial void ActiveTexture(Int32 texture);
            [LibraryImport(Gl.Library, EntryPoint = "glAttachShader")]
            internal static partial void AttachShader(UInt32 program, UInt32 shader);
            [LibraryImport(Gl.Library, EntryPoint = "glBeginConditionalRender")]
            internal static partial void BeginConditionalRender(UInt32 id, OpenGL.ConditionalRenderType mode);
            [LibraryImport(Gl.Library, EntryPoint = "glEndConditionalRender")]
            internal static partial void EndConditionalRender();
            [LibraryImport(Gl.Library, EntryPoint = "glBeginQuery")]
            internal static partial void BeginQuery(OpenGL.QueryTarget target, UInt32 id);
            [LibraryImport(Gl.Library, EntryPoint = "glEndQuery")]
            internal static partial void EndQuery(OpenGL.QueryTarget target);
            [LibraryImport(Gl.Library, EntryPoint = "glBeginQueryIndexed")]
            internal static partial void BeginQueryIndexed(OpenGL.QueryTarget target, UInt32 index, UInt32 id);
            [LibraryImport(Gl.Library, EntryPoint = "glEndQueryIndexed")]
            internal static partial void EndQueryIndexed(OpenGL.QueryTarget target, UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glBeginTransformFeedback")]
            internal static partial void BeginTransformFeedback(OpenGL.BeginFeedbackMode primitiveMode);
            [LibraryImport(Gl.Library, EntryPoint = "glEndTransformFeedback")]
            internal static partial void EndTransformFeedback();
            [LibraryImport(Gl.Library, EntryPoint = "glBindAttribLocation", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial void BindAttribLocation(UInt32 program, UInt32 index, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glBindBuffer")]
            internal static partial void BindBuffer(OpenGL.BufferTarget target, UInt32 buffer);
            [LibraryImport(Gl.Library, EntryPoint = "glBindBufferBase")]
            internal static partial void BindBufferBase(OpenGL.BufferTarget target, UInt32 index, UInt32 buffer);
            [LibraryImport(Gl.Library, EntryPoint = "glBindBufferRange")]
            internal static partial void BindBufferRange(BufferTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            [LibraryImport(Gl.Library, EntryPoint = "glBindBuffersBase")]
            internal static partial void BindBuffersBase(OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers);
            [LibraryImport(Gl.Library, EntryPoint = "glBindBuffersRange")]
            internal static partial void BindBuffersRange(OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, IntPtr[] sizes);
            [LibraryImport(Gl.Library, EntryPoint = "glBindFragDataLocation", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial void BindFragDataLocation(UInt32 program, UInt32 colorNumber, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glBindFragDataLocationIndexed", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glBindFramebuffer")]
            internal static partial void BindFramebuffer(OpenGL.FramebufferTarget target, UInt32 framebuffer);
            [LibraryImport(Gl.Library, EntryPoint = "glBindImageTexture")]
            internal static partial void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, [MarshalAs(UnmanagedType.Bool)]Boolean layered, Int32 layer, OpenGL.BufferAccess access, OpenGL.PixelInternalFormat format);
            [LibraryImport(Gl.Library, EntryPoint = "glBindImageTextures")]
            internal static partial void BindImageTextures(UInt32 first, Int32 count, UInt32[] textures);
            [LibraryImport(Gl.Library, EntryPoint = "glBindProgramPipeline")]
            internal static partial void BindProgramPipeline(UInt32 pipeline);
            [LibraryImport(Gl.Library, EntryPoint = "glBindRenderbuffer")]
            internal static partial void BindRenderbuffer(OpenGL.RenderbufferTarget target, UInt32 renderbuffer);
            [LibraryImport(Gl.Library, EntryPoint = "glBindSampler")]
            internal static partial void BindSampler(UInt32 unit, UInt32 sampler);
            [LibraryImport(Gl.Library, EntryPoint = "glBindSamplers")]
            internal static partial void BindSamplers(UInt32 first, Int32 count, UInt32[] samplers);
            [LibraryImport(Gl.Library, EntryPoint = "glBindTexture")]
            internal static partial void BindTexture(OpenGL.TextureTarget target, UInt32 texture);
            [LibraryImport(Gl.Library, EntryPoint = "glBindTextures")]
            internal static partial void BindTextures(UInt32 first, Int32 count, UInt32[] textures);
            [LibraryImport(Gl.Library, EntryPoint = "glBindTextureUnit")]
            internal static partial void BindTextureUnit(UInt32 unit, UInt32 texture);
            [LibraryImport(Gl.Library, EntryPoint = "glBindTransformFeedback")]
            internal static partial void BindTransformFeedback(OpenGL.NvTransformFeedback2 target, UInt32 id);
            [LibraryImport(Gl.Library, EntryPoint = "glBindVertexArray")]
            internal static partial void BindVertexArray(UInt32 array);
            [LibraryImport(Gl.Library, EntryPoint = "glBindVertexBuffer")]
            internal static partial void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, IntPtr stride);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexArrayVertexBuffer")]
            internal static partial void VertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
            [LibraryImport(Gl.Library, EntryPoint = "glBindVertexBuffers")]
            internal static partial void BindVertexBuffers(UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexArrayVertexBuffers")]
            internal static partial void VertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);
            [LibraryImport(Gl.Library, EntryPoint = "glBlendColor")]
            internal static partial void BlendColor(Single red, Single green, Single blue, Single alpha);
            [LibraryImport(Gl.Library, EntryPoint = "glBlendEquation")]
            internal static partial void BlendEquation(OpenGL.BlendEquationMode mode);
            [LibraryImport(Gl.Library, EntryPoint = "glBlendEquationi")]
            internal static partial void BlendEquationi(UInt32 buf, OpenGL.BlendEquationMode mode);
            [LibraryImport(Gl.Library, EntryPoint = "glBlendEquationSeparate")]
            internal static partial void BlendEquationSeparate(OpenGL.BlendEquationMode modeRGB, OpenGL.BlendEquationMode modeAlpha);
            [LibraryImport(Gl.Library, EntryPoint = "glBlendEquationSeparatei")]
            internal static partial void BlendEquationSeparatei(UInt32 buf, OpenGL.BlendEquationMode modeRGB, OpenGL.BlendEquationMode modeAlpha);
            [LibraryImport(Gl.Library, EntryPoint = "glBlendFunc")]
            internal static partial void BlendFunc(OpenGL.BlendingFactorSrc sfactor, OpenGL.BlendingFactorDest dfactor);
            [LibraryImport(Gl.Library, EntryPoint = "glBlendFunci")]
            internal static partial void BlendFunci(UInt32 buf, OpenGL.BlendingFactorSrc sfactor, OpenGL.BlendingFactorDest dfactor);
            [LibraryImport(Gl.Library, EntryPoint = "glBlendFuncSeparate")]
            internal static partial void BlendFuncSeparate(OpenGL.BlendingFactorSrc srcRGB, OpenGL.BlendingFactorDest dstRGB, OpenGL.BlendingFactorSrc srcAlpha, OpenGL.BlendingFactorDest dstAlpha);
            [LibraryImport(Gl.Library, EntryPoint = "glBlendFuncSeparatei")]
            internal static partial void BlendFuncSeparatei(UInt32 buf, OpenGL.BlendingFactorSrc srcRGB, OpenGL.BlendingFactorDest dstRGB, OpenGL.BlendingFactorSrc srcAlpha, OpenGL.BlendingFactorDest dstAlpha);
            [LibraryImport(Gl.Library, EntryPoint = "glBlitFramebuffer")]
            internal static partial void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenGL.ClearBufferMask mask, OpenGL.BlitFramebufferFilter filter);
            [LibraryImport(Gl.Library, EntryPoint = "glBlitNamedFramebuffer")]
            internal static partial void BlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenGL.ClearBufferMask mask, OpenGL.BlitFramebufferFilter filter);
            [LibraryImport(Gl.Library, EntryPoint = "glBufferData")]
            internal static partial void BufferData(OpenGL.BufferTarget target, IntPtr size, IntPtr data, OpenGL.BufferUsageHint usage);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedBufferData")]
            internal static partial void NamedBufferData(UInt32 buffer, Int32 size, IntPtr data, OpenGL.BufferUsageHint usage);
            [LibraryImport(Gl.Library, EntryPoint = "glBufferStorage")]
            internal static partial void BufferStorage(OpenGL.BufferTarget target, IntPtr size, IntPtr data, UInt32 flags);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedBufferStorage")]
            internal static partial void NamedBufferStorage(UInt32 buffer, Int32 size, IntPtr data, UInt32 flags);
            [LibraryImport(Gl.Library, EntryPoint = "glBufferSubData")]
            internal static partial void BufferSubData(OpenGL.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedBufferSubData")]
            internal static partial void NamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCheckFramebufferStatus")]
            internal static partial OpenGL.FramebufferErrorCode CheckFramebufferStatus(OpenGL.FramebufferTarget target);
            [LibraryImport(Gl.Library, EntryPoint = "glCheckNamedFramebufferStatus")]
            internal static partial OpenGL.FramebufferErrorCode CheckNamedFramebufferStatus(UInt32 framebuffer, OpenGL.FramebufferTarget target);
            [LibraryImport(Gl.Library, EntryPoint = "glClampColor")]
            internal static partial void ClampColor(OpenGL.ClampColorTarget target, OpenGL.ClampColorMode clamp);
            [LibraryImport(Gl.Library, EntryPoint = "glClear")]
            internal static partial void Clear(OpenGL.ClearBufferMask mask);
            [LibraryImport(Gl.Library, EntryPoint = "glClearBufferiv")]
            internal static partial void ClearBufferiv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glClearBufferuiv")]
            internal static partial void ClearBufferuiv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glClearBufferfv")]
            internal static partial void ClearBufferfv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glClearBufferfi")]
            internal static partial void ClearBufferfi(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            [LibraryImport(Gl.Library, EntryPoint = "glClearNamedFramebufferiv")]
            internal static partial void ClearNamedFramebufferiv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glClearNamedFramebufferuiv")]
            internal static partial void ClearNamedFramebufferuiv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glClearNamedFramebufferfv")]
            internal static partial void ClearNamedFramebufferfv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glClearNamedFramebufferfi")]
            internal static partial void ClearNamedFramebufferfi(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            [LibraryImport(Gl.Library, EntryPoint = "glClearBufferData")]
            internal static partial void ClearBufferData(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glClearNamedBufferData")]
            internal static partial void ClearNamedBufferData(UInt32 buffer, OpenGL.SizedInternalFormat internalFormat, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glClearBufferSubData")]
            internal static partial void ClearBufferSubData(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, IntPtr offset, IntPtr size, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glClearNamedBufferSubData")]
            internal static partial void ClearNamedBufferSubData(UInt32 buffer, OpenGL.SizedInternalFormat internalFormat, IntPtr offset, Int32 size, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glClearColor")]
            internal static partial void ClearColor(Single red, Single green, Single blue, Single alpha);
            [LibraryImport(Gl.Library, EntryPoint = "glClearDepth")]
            internal static partial void ClearDepth(Double depth);
            [LibraryImport(Gl.Library, EntryPoint = "glClearDepthf")]
            internal static partial void ClearDepthf(Single depth);
            [LibraryImport(Gl.Library, EntryPoint = "glClearStencil")]
            internal static partial void ClearStencil(Int32 s);
            [LibraryImport(Gl.Library, EntryPoint = "glClearTexImage")]
            internal static partial void ClearTexImage(UInt32 texture, Int32 level, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glClearTexSubImage")]
            internal static partial void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glClientWaitSync")]
            internal static partial OpenGL.ArbSync ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
            [LibraryImport(Gl.Library, EntryPoint = "glClipControl")]
            internal static partial void ClipControl(OpenGL.ClipControlOrigin origin, OpenGL.ClipControlDepth depth);
            [LibraryImport(Gl.Library, EntryPoint = "glColorMask")]
            internal static partial void ColorMask([MarshalAs(UnmanagedType.Bool)]Boolean red, [MarshalAs(UnmanagedType.Bool)]Boolean green, [MarshalAs(UnmanagedType.Bool)]Boolean blue, [MarshalAs(UnmanagedType.Bool)]Boolean alpha);
            [LibraryImport(Gl.Library, EntryPoint = "glColorMaski")]
            internal static partial void ColorMaski(UInt32 buf, [MarshalAs(UnmanagedType.Bool)]Boolean red, [MarshalAs(UnmanagedType.Bool)]Boolean green, [MarshalAs(UnmanagedType.Bool)]Boolean blue, [MarshalAs(UnmanagedType.Bool)]Boolean alpha);
            [LibraryImport(Gl.Library, EntryPoint = "glCompileShader")]
            internal static partial void CompileShader(UInt32 shader);
            [LibraryImport(Gl.Library, EntryPoint = "glCompressedTexImage1D")]
            internal static partial void CompressedTexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCompressedTexImage2D")]
            internal static partial void CompressedTexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCompressedTexImage3D")]
            internal static partial void CompressedTexImage3D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCompressedTexSubImage1D")]
            internal static partial void CompressedTexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCompressedTextureSubImage1D")]
            internal static partial void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCompressedTexSubImage2D")]
            internal static partial void CompressedTexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCompressedTextureSubImage2D")]
            internal static partial void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCompressedTexSubImage3D")]
            internal static partial void CompressedTexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCompressedTextureSubImage3D")]
            internal static partial void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyBufferSubData")]
            internal static partial void CopyBufferSubData(OpenGL.BufferTarget readTarget, OpenGL.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyNamedBufferSubData")]
            internal static partial void CopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, Int32 size);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyImageSubData")]
            internal static partial void CopyImageSubData(UInt32 srcName, OpenGL.BufferTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenGL.BufferTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyTexImage1D")]
            internal static partial void CopyTexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 border);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyTexImage2D")]
            internal static partial void CopyTexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyTexSubImage1D")]
            internal static partial void CopyTexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyTextureSubImage1D")]
            internal static partial void CopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyTexSubImage2D")]
            internal static partial void CopyTexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyTextureSubImage2D")]
            internal static partial void CopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyTexSubImage3D")]
            internal static partial void CopyTexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glCopyTextureSubImage3D")]
            internal static partial void CopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateBuffers")]
            internal static partial void CreateBuffers(Int32 n, UInt32[] buffers);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateFramebuffers")]
            internal static partial void CreateFramebuffers(Int32 n, UInt32[] ids);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateProgram")]
            internal static partial UInt32 CreateProgram();
            [LibraryImport(Gl.Library, EntryPoint = "glCreateProgramPipelines")]
            internal static partial void CreateProgramPipelines(Int32 n, UInt32[] pipelines);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateQueries")]
            internal static partial void CreateQueries(OpenGL.QueryTarget target, Int32 n, UInt32[] ids);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateRenderbuffers")]
            internal static partial void CreateRenderbuffers(Int32 n, UInt32[] renderbuffers);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateSamplers")]
            internal static partial void CreateSamplers(Int32 n, UInt32[] samplers);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateShader")]
            internal static partial UInt32 CreateShader(OpenGL.ShaderType shaderType);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateShaderProgramv", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial UInt32 CreateShaderProgramv(OpenGL.ShaderType type, Int32 count, String[] strings);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateTextures")]
            internal static partial void CreateTextures(OpenGL.TextureTarget target, Int32 n, UInt32[] textures);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateTransformFeedbacks")]
            internal static partial void CreateTransformFeedbacks(Int32 n, UInt32[] ids);
            [LibraryImport(Gl.Library, EntryPoint = "glCreateVertexArrays")]
            internal static partial void CreateVertexArrays(Int32 n, UInt32[] arrays);
            [LibraryImport(Gl.Library, EntryPoint = "glCullFace")]
            internal static partial void CullFace(OpenGL.CullFaceMode mode);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteBuffers")]
            internal static partial void DeleteBuffers(Int32 n, UInt32[] buffers);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteFramebuffers")]
            internal static partial void DeleteFramebuffers(Int32 n, UInt32[] framebuffers);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteProgram")]
            internal static partial void DeleteProgram(UInt32 program);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteProgramPipelines")]
            internal static partial void DeleteProgramPipelines(Int32 n, UInt32[] pipelines);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteQueries")]
            internal static partial void DeleteQueries(Int32 n, UInt32[] ids);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteRenderbuffers")]
            internal static partial void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteSamplers")]
            internal static partial void DeleteSamplers(Int32 n, UInt32[] samplers);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteShader")]
            internal static partial void DeleteShader(UInt32 shader);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteSync")]
            internal static partial void DeleteSync(IntPtr sync);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteTextures")]
            internal static partial void DeleteTextures(Int32 n, UInt32[] textures);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteTransformFeedbacks")]
            internal static partial void DeleteTransformFeedbacks(Int32 n, UInt32[] ids);
            [LibraryImport(Gl.Library, EntryPoint = "glDeleteVertexArrays")]
            internal static partial void DeleteVertexArrays(Int32 n, UInt32[] arrays);
            [LibraryImport(Gl.Library, EntryPoint = "glDepthFunc")]
            internal static partial void DepthFunc(OpenGL.DepthFunction func);
            [LibraryImport(Gl.Library, EntryPoint = "glDepthMask")]
            internal static partial void DepthMask([MarshalAs(UnmanagedType.Bool)]Boolean flag);
            [LibraryImport(Gl.Library, EntryPoint = "glDepthRange")]
            internal static partial void DepthRange(Double nearVal, Double farVal);
            [LibraryImport(Gl.Library, EntryPoint = "glDepthRangef")]
            internal static partial void DepthRangef(Single nearVal, Single farVal);
            [LibraryImport(Gl.Library, EntryPoint = "glDepthRangeArrayv")]
            internal static partial void DepthRangeArrayv(UInt32 first, Int32 count, Double[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glDepthRangeIndexed")]
            internal static partial void DepthRangeIndexed(UInt32 index, Double nearVal, Double farVal);
            [LibraryImport(Gl.Library, EntryPoint = "glDetachShader")]
            internal static partial void DetachShader(UInt32 program, UInt32 shader);
            [LibraryImport(Gl.Library, EntryPoint = "glDispatchCompute")]
            internal static partial void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);
            [LibraryImport(Gl.Library, EntryPoint = "glDispatchComputeIndirect")]
            internal static partial void DispatchComputeIndirect(IntPtr indirect);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawArrays")]
            internal static partial void DrawArrays(OpenGL.BeginMode mode, Int32 first, Int32 count);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawArraysIndirect")]
            internal static partial void DrawArraysIndirect(OpenGL.BeginMode mode, IntPtr indirect);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawArraysInstanced")]
            internal static partial void DrawArraysInstanced(OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawArraysInstancedBaseInstance")]
            internal static partial void DrawArraysInstancedBaseInstance(OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount, UInt32 baseinstance);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawBuffer")]
            internal static partial void DrawBuffer(OpenGL.DrawBufferMode buf);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedFramebufferDrawBuffer")]
            internal static partial void NamedFramebufferDrawBuffer(UInt32 framebuffer, OpenGL.DrawBufferMode buf);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawBuffers")]
            internal static partial void DrawBuffers(Int32 n, OpenGL.DrawBuffersEnum[] bufs);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedFramebufferDrawBuffers")]
            internal static partial void NamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, OpenGL.DrawBufferMode[] bufs);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawElements")]
            internal static partial void DrawElements(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawElementsBaseVertex")]
            internal static partial void DrawElementsBaseVertex(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawElementsIndirect")]
            internal static partial void DrawElementsIndirect(OpenGL.BeginMode mode, OpenGL.DrawElementsType type, IntPtr indirect);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawElementsInstanced")]
            internal static partial void DrawElementsInstanced(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawElementsInstancedBaseInstance")]
            internal static partial void DrawElementsInstancedBaseInstance(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, UInt32 baseinstance);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawElementsInstancedBaseVertex")]
            internal static partial void DrawElementsInstancedBaseVertex(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
            internal static partial void DrawElementsInstancedBaseVertexBaseInstance(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawRangeElements")]
            internal static partial void DrawRangeElements(OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenGL.DrawElementsType type, IntPtr indices);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawRangeElementsBaseVertex")]
            internal static partial void DrawRangeElementsBaseVertex(OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawTransformFeedback")]
            internal static partial void DrawTransformFeedback(OpenGL.NvTransformFeedback2 mode, UInt32 id);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawTransformFeedbackInstanced")]
            internal static partial void DrawTransformFeedbackInstanced(OpenGL.BeginMode mode, UInt32 id, Int32 primcount);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawTransformFeedbackStream")]
            internal static partial void DrawTransformFeedbackStream(OpenGL.NvTransformFeedback2 mode, UInt32 id, UInt32 stream);
            [LibraryImport(Gl.Library, EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
            internal static partial void DrawTransformFeedbackStreamInstanced(OpenGL.BeginMode mode, UInt32 id, UInt32 stream, Int32 primcount);
            [LibraryImport(Gl.Library, EntryPoint = "glEnable")]
            internal static partial void Enable(OpenGL.EnableCap cap);
            [LibraryImport(Gl.Library, EntryPoint = "glDisable")]
            internal static partial void Disable(OpenGL.EnableCap cap);
            [LibraryImport(Gl.Library, EntryPoint = "glEnablei")]
            internal static partial void Enablei(OpenGL.EnableCap cap, UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glDisablei")]
            internal static partial void Disablei(OpenGL.EnableCap cap, UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glEnableVertexAttribArray")]
            internal static partial void EnableVertexAttribArray(UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glDisableVertexAttribArray")]
            internal static partial void DisableVertexAttribArray(UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glEnableVertexArrayAttrib")]
            internal static partial void EnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glDisableVertexArrayAttrib")]
            internal static partial void DisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glFenceSync")]
            internal static partial IntPtr FenceSync(OpenGL.ArbSync condition, UInt32 flags);
            [LibraryImport(Gl.Library, EntryPoint = "glFinish")]
            internal static partial void Finish();
            [LibraryImport(Gl.Library, EntryPoint = "glFlush")]
            internal static partial void Flush();
            [LibraryImport(Gl.Library, EntryPoint = "glFlushMappedBufferRange")]
            internal static partial void FlushMappedBufferRange(OpenGL.BufferTarget target, IntPtr offset, IntPtr length);
            [LibraryImport(Gl.Library, EntryPoint = "glFlushMappedNamedBufferRange")]
            internal static partial void FlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length);
            [LibraryImport(Gl.Library, EntryPoint = "glFramebufferParameteri")]
            internal static partial void FramebufferParameteri(OpenGL.FramebufferTarget target, OpenGL.FramebufferPName pname, Int32 param);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedFramebufferParameteri")]
            internal static partial void NamedFramebufferParameteri(UInt32 framebuffer, OpenGL.FramebufferPName pname, Int32 param);
            [LibraryImport(Gl.Library, EntryPoint = "glFramebufferRenderbuffer")]
            internal static partial void FramebufferRenderbuffer(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedFramebufferRenderbuffer")]
            internal static partial void NamedFramebufferRenderbuffer(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            [LibraryImport(Gl.Library, EntryPoint = "glFramebufferTexture")]
            internal static partial void FramebufferTexture(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            [LibraryImport(Gl.Library, EntryPoint = "glFramebufferTexture1D")]
            internal static partial void FramebufferTexture1D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            [LibraryImport(Gl.Library, EntryPoint = "glFramebufferTexture2D")]
            internal static partial void FramebufferTexture2D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            [LibraryImport(Gl.Library, EntryPoint = "glFramebufferTexture3D")]
            internal static partial void FramebufferTexture3D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level, Int32 layer);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedFramebufferTexture")]
            internal static partial void NamedFramebufferTexture(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            [LibraryImport(Gl.Library, EntryPoint = "glFramebufferTextureLayer")]
            internal static partial void FramebufferTextureLayer(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedFramebufferTextureLayer")]
            internal static partial void NamedFramebufferTextureLayer(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            [LibraryImport(Gl.Library, EntryPoint = "glFrontFace")]
            internal static partial void FrontFace(OpenGL.FrontFaceDirection mode);
            [LibraryImport(Gl.Library, EntryPoint = "glGenBuffers")]
            internal static partial void GenBuffers(Int32 n, UInt32[] buffers);
            [LibraryImport(Gl.Library, EntryPoint = "glGenerateMipmap")]
            internal static partial void GenerateMipmap(OpenGL.GenerateMipmapTarget target);
            [LibraryImport(Gl.Library, EntryPoint = "glGenerateTextureMipmap")]
            internal static partial void GenerateTextureMipmap(UInt32 texture);
            [LibraryImport(Gl.Library, EntryPoint = "glGenFramebuffers")]
            internal static partial void GenFramebuffers(Int32 n, UInt32[] ids);
            [LibraryImport(Gl.Library, EntryPoint = "glGenProgramPipelines")]
            internal static partial void GenProgramPipelines(Int32 n, UInt32[] pipelines);
            [LibraryImport(Gl.Library, EntryPoint = "glGenQueries")]
            internal static partial void GenQueries(Int32 n, UInt32[] ids);
            [LibraryImport(Gl.Library, EntryPoint = "glGenRenderbuffers")]
            internal static partial void GenRenderbuffers(Int32 n, UInt32[] renderbuffers);
            [LibraryImport(Gl.Library, EntryPoint = "glGenSamplers")]
            internal static partial void GenSamplers(Int32 n, UInt32[] samplers);
            [LibraryImport(Gl.Library, EntryPoint = "glGenTextures")]
            internal static partial void GenTextures(Int32 n, UInt32[] textures);
            [LibraryImport(Gl.Library, EntryPoint = "glGenTransformFeedbacks")]
            internal static partial void GenTransformFeedbacks(Int32 n, UInt32[] ids);
            [LibraryImport(Gl.Library, EntryPoint = "glGenVertexArrays")]
            internal static partial void GenVertexArrays(Int32 n, UInt32[] arrays);
            [LibraryImport(Gl.Library, EntryPoint = "glGetBooleanv")]
            internal static partial void GetBooleanv(OpenGL.GetPName pname, [MarshalAs(UnmanagedType.Bool)] ref Boolean data); // out Boolean[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetDoublev")]
            internal static partial void GetDoublev(OpenGL.GetPName pname, ref Double data); // Double[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetFloatv")]
            internal static partial void GetFloatv(OpenGL.GetPName pname, ref Single data); // Single[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetIntegerv")]
            internal static partial void GetIntegerv(OpenGL.GetPName pname, ref Int32 data); // Int32[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetInteger64v")]
            internal static partial void GetInteger64v(OpenGL.ArbSync pname, ref Int64 data); // Int64[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetBooleani_v")]
            internal static partial void GetBooleani_v(OpenGL.GetPName target, UInt32 index, [MarshalAs(UnmanagedType.Bool)] ref Boolean data); // out Boolean[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetIntegeri_v")]
            internal static partial void GetIntegeri_v(OpenGL.GetPName target, UInt32 index, ref Int32 data); // Int32[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetFloati_v")]
            internal static partial void GetFloati_v(OpenGL.GetPName target, UInt32 index, ref Single data); // Single[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetDoublei_v")]
            internal static partial void GetDoublei_v(OpenGL.GetPName target, UInt32 index, ref Double data); // Double[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetInteger64i_v")]
            internal static partial void GetInteger64i_v(OpenGL.GetPName target, UInt32 index, ref Int64 data); // Int64[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveAtomicCounterBufferiv")]
            internal static partial void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, OpenGL.AtomicCounterParameterName pname, ref Int32 @params); // Int32[] @params
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveAttrib")]
            internal static partial void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref OpenGL.ActiveAttribType type, byte[] name); // Int32[] length, Int32[] size, out OpenGL.ActiveAttribType[] type, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveSubroutineName")]
            internal static partial void GetActiveSubroutineName(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, ref Int32 length, byte[] name); // Int32[] length, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveSubroutineUniformiv")]
            internal static partial void GetActiveSubroutineUniformiv(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, OpenGL.SubroutineParameterName pname, ref Int32 values); // Int32[] values);
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveSubroutineUniformName")]
            internal static partial void GetActiveSubroutineUniformName(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, ref Int32 length, byte[] name); // Int32[] length, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveUniform")]
            internal static partial void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref OpenGL.ActiveUniformType type, byte[] name); // Int32[] length, Int32[] size, out OpenGL.ActiveUniformType[] type, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveUniformBlockiv")]
            internal static partial void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenGL.ActiveUniformBlockParameter pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveUniformBlockName")]
            internal static partial void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, ref Int32 length, byte[] uniformBlockName); // Int32[] length, String uniformBlockName);
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveUniformName")]
            internal static partial void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, ref Int32 length, byte[] uniformName); // Int32[] length, String uniformName);
            [LibraryImport(Gl.Library, EntryPoint = "glGetActiveUniformsiv")]
            internal static partial void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32[] uniformIndices, OpenGL.ActiveUniformType pname, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetAttachedShaders")]
            internal static partial void GetAttachedShaders(UInt32 program, Int32 maxCount, ref Int32 count, UInt32[] shaders); // Int32[] count, UInt32[] shaders);
            [LibraryImport(Gl.Library, EntryPoint = "glGetAttribLocation", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial Int32 GetAttribLocation(UInt32 program, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetBufferParameteriv")]
            internal static partial void GetBufferParameteriv(OpenGL.BufferTarget target, OpenGL.BufferParameterName value, out Int32 data); // Int32[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetBufferParameteri64v")]
            internal static partial void GetBufferParameteri64v(OpenGL.BufferTarget target, OpenGL.BufferParameterName value, out Int64 data); // Int64[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetNamedBufferParameteriv")]
            internal static partial void GetNamedBufferParameteriv(UInt32 buffer, OpenGL.BufferParameterName pname, out Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetNamedBufferParameteri64v")]
            internal static partial void GetNamedBufferParameteri64v(UInt32 buffer, OpenGL.BufferParameterName pname, out Int64 @params); // Int64[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetBufferPointerv")]
            internal static partial void GetBufferPointerv(OpenGL.BufferTarget target, OpenGL.BufferPointer pname, out IntPtr @params); // out IntPtr @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetNamedBufferPointerv")]
            internal static partial void GetNamedBufferPointerv(UInt32 buffer, OpenGL.BufferPointer pname, out IntPtr @params); // out IntPtr @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetBufferSubData")]
            internal static partial void GetBufferSubData(OpenGL.BufferTarget target, IntPtr offset, IntPtr size, out IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetNamedBufferSubData")]
            internal static partial void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, out IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glGetCompressedTexImage")]
            internal static partial void GetCompressedTexImage(OpenGL.TextureTarget target, Int32 level, out IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glGetnCompressedTexImage")]
            internal static partial void GetnCompressedTexImage(OpenGL.TextureTarget target, Int32 level, Int32 bufSize, out IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glGetCompressedTextureImage")]
            internal static partial void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, out IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glGetCompressedTextureSubImage")]
            internal static partial void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, out IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glGetError")]
            internal static partial OpenGL.ErrorCode GetError();
            [LibraryImport(Gl.Library, EntryPoint = "glGetFragDataIndex", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial Int32 GetFragDataIndex(UInt32 program, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetFragDataLocation", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial Int32 GetFragDataLocation(UInt32 program, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetFramebufferAttachmentParameteriv")]
            internal static partial void GetFramebufferAttachmentParameteriv(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.FramebufferParameterName pname, out Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
            internal static partial void GetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, OpenGL.FramebufferParameterName pname, out Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetFramebufferParameteriv")]
            internal static partial void GetFramebufferParameteriv(OpenGL.FramebufferTarget target, OpenGL.FramebufferPName pname, out Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetNamedFramebufferParameteriv")]
            internal static partial void GetNamedFramebufferParameteriv(UInt32 framebuffer, OpenGL.FramebufferPName pname, out Int32 param); // Int32[] param);
            [LibraryImport(Gl.Library, EntryPoint = "glGetGraphicsResetStatus")]
            internal static partial OpenGL.GraphicResetStatus GetGraphicsResetStatus();
            [LibraryImport(Gl.Library, EntryPoint = "glGetInternalformativ")]
            internal static partial void GetInternalformativ(OpenGL.TextureTarget target, OpenGL.PixelInternalFormat internalFormat, OpenGL.GetPName pname, Int32 bufSize, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetInternalformati64v")]
            internal static partial void GetInternalformati64v(OpenGL.TextureTarget target, OpenGL.PixelInternalFormat internalFormat, OpenGL.GetPName pname, Int32 bufSize, Int64[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetMultisamplefv")]
            internal static partial void GetMultisamplefv(OpenGL.GetMultisamplePName pname, UInt32 index, [MarshalUsing(ConstantElementCount = 2)]Single[] val);
            [LibraryImport(Gl.Library, EntryPoint = "glGetObjectLabel")]
            internal static partial void GetObjectLabel(OpenGL.ObjectLabel identifier, UInt32 name, Int32 bufSize, ref Int32 length, byte[] label); // Int32[] length, String label);
            [LibraryImport(Gl.Library, EntryPoint = "glGetObjectPtrLabel")]
            internal static partial void GetObjectPtrLabel(ref IntPtr ptr, Int32 bufSize, ref Int32 length, byte[] label); // Int32[] length, String label);
            [LibraryImport(Gl.Library, EntryPoint = "glGetPointerv")]
            internal static partial void GetPointerv(OpenGL.GetPointerParameter pname, out nint @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramiv")]
            internal static partial void GetProgramiv(UInt32 program, OpenGL.ProgramParameter pname, out Int32 @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramBinary")]
            internal static partial void GetProgramBinary(UInt32 program, Int32 bufsize, ref Int32 length, ref Int32 binaryFormat, nint binary); // Int32[] length, Int32[] binaryFormat, out IntPtr binary);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramInfoLog")]
            internal static partial void GetProgramInfoLog (UInt32 program, Int32 maxLength, ref Int32 length, byte[] infoLog); // Int32[] length, String infoLog);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramInterfaceiv")]
            internal static partial void GetProgramInterfaceiv(UInt32 program, OpenGL.ProgramInterface programInterface, OpenGL.ProgramInterfaceParameterName pname, out Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramPipelineiv")]
            internal static partial void GetProgramPipelineiv(UInt32 pipeline, Int32 pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramPipelineInfoLog")]
            internal static partial void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, ref Int32 length, byte[] infoLog); // Int32[] length, String infoLog);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramResourceiv")]
            internal static partial void GetProgramResourceiv(UInt32 program, OpenGL.ProgramInterface programInterface, UInt32 index, Int32 propCount, OpenGL.ProgramResourceParameterName[] props, Int32 bufSize, ref Int32 length, Int32[] @params); // Int32[] length, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramResourceIndex", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial UInt32 GetProgramResourceIndex(UInt32 program, OpenGL.ProgramInterface programInterface, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramResourceLocation", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial Int32 GetProgramResourceLocation(UInt32 program, OpenGL.ProgramInterface programInterface, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramResourceLocationIndex", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial Int32 GetProgramResourceLocationIndex(UInt32 program, OpenGL.ProgramInterface programInterface, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramResourceName")]
            internal static partial void GetProgramResourceName(UInt32 program, OpenGL.ProgramInterface programInterface, UInt32 index, Int32 bufSize, ref Int32 length, byte[] name); // Int32[] length, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetProgramStageiv")]
            internal static partial void GetProgramStageiv(UInt32 program, OpenGL.ShaderType shadertype, OpenGL.ProgramStageParameterName pname, out Int32 values); // Int32[] values);
            [LibraryImport(Gl.Library, EntryPoint = "glGetQueryIndexediv")]
            internal static partial void GetQueryIndexediv(OpenGL.QueryTarget target, UInt32 index, OpenGL.GetQueryParam pname, out Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetQueryiv")]
            internal static partial void GetQueryiv(OpenGL.QueryTarget target, OpenGL.GetQueryParam pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetQueryObjectiv")]
            internal static partial void GetQueryObjectiv(UInt32 id, OpenGL.GetQueryObjectParam pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetQueryObjectuiv")]
            internal static partial void GetQueryObjectuiv(UInt32 id, OpenGL.GetQueryObjectParam pname, ref UInt32 @params); // UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetQueryObjecti64v")]
            internal static partial void GetQueryObjecti64v(UInt32 id, OpenGL.GetQueryObjectParam pname, ref Int64 @params); // Int64[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetQueryObjectui64v")]
            internal static partial void GetQueryObjectui64v(UInt32 id, OpenGL.GetQueryObjectParam pname, ref UInt64 @params); // UInt64[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetRenderbufferParameteriv")]
            internal static partial void GetRenderbufferParameteriv(OpenGL.RenderbufferTarget target, OpenGL.RenderbufferParameterName pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetNamedRenderbufferParameteriv")]
            internal static partial void GetNamedRenderbufferParameteriv(UInt32 renderbuffer, OpenGL.RenderbufferParameterName pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetSamplerParameterfv")]
            internal static partial void GetSamplerParameterfv(UInt32 sampler, OpenGL.TextureParameterName pname, ref Single @params); // Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetSamplerParameteriv")]
            internal static partial void GetSamplerParameteriv(UInt32 sampler, OpenGL.TextureParameterName pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetSamplerParameterIiv")]
            internal static partial void GetSamplerParameterIiv(UInt32 sampler, OpenGL.TextureParameterName pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetSamplerParameterIuiv")]
            internal static partial void GetSamplerParameterIuiv(UInt32 sampler, OpenGL.TextureParameterName pname, ref UInt32 @params); // UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetShaderiv")]
            internal static partial void GetShaderiv(UInt32 shader, OpenGL.ShaderParameter pname, Int32[] @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetShaderInfoLog")]
            internal static partial void GetShaderInfoLog(UInt32 shader, Int32 maxLength, ref Int32 length, byte[] infoLog); // Int32[] length, String infoLog);
            [LibraryImport(Gl.Library, EntryPoint = "glGetShaderPrecisionFormat")]
            internal static partial void GetShaderPrecisionFormat(OpenGL.ShaderType shaderType, Int32 precisionType, [MarshalAs(UnmanagedType.LPArray, SizeConst=2)] Int32[] range, out Int32 precision); // Int32[] precision);
            [LibraryImport(Gl.Library, EntryPoint = "glGetShaderSource")]
            internal static partial void GetShaderSource(UInt32 shader, Int32 bufSize, ref Int32 length, byte[] source); // Int32[] length, String source);
            [LibraryImport(Gl.Library, EntryPoint = "glGetString")]
            internal static partial IntPtr GetString(OpenGL.StringName name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetStringi")]
            internal static partial IntPtr GetStringi(OpenGL.StringName name, UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glGetSubroutineIndex", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial UInt32 GetSubroutineIndex(UInt32 program, OpenGL.ShaderType shadertype, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetSubroutineUniformLocation", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial Int32 GetSubroutineUniformLocation(UInt32 program, OpenGL.ShaderType shadertype, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetSynciv")]
            internal static partial void GetSynciv(IntPtr sync, OpenGL.ArbSync pname, Int32 bufSize, ref Int32 length, Int32[] values); // Int32[] length, Int32[] values);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTexImage")]
            internal static partial void GetTexImage(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, out IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glGetnTexImage")]
            internal static partial void GetnTexImage(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, out IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTextureImage")]
            internal static partial void GetTextureImage(UInt32 texture, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, out IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTexLevelParameterfv")]
            internal static partial void GetTexLevelParameterfv(OpenGL.GetPName target, Int32 level, OpenGL.GetTextureLevelParameter pname, ref Single @params); // Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTexLevelParameteriv")]
            internal static partial void GetTexLevelParameteriv(OpenGL.GetPName target, Int32 level, OpenGL.GetTextureLevelParameter pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTextureLevelParameterfv")]
            internal static partial void GetTextureLevelParameterfv(UInt32 texture, Int32 level, OpenGL.GetTextureLevelParameter pname, ref Single @params); // Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTextureLevelParameteriv")]
            internal static partial void GetTextureLevelParameteriv(UInt32 texture, Int32 level, OpenGL.GetTextureLevelParameter pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTexParameterfv")]
            internal static partial void GetTexParameterfv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, ref Single @params); // Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTexParameteriv")]
            internal static partial void GetTexParameteriv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTexParameterIiv")]
            internal static partial void GetTexParameterIiv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTexParameterIuiv")]
            internal static partial void GetTexParameterIuiv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, ref UInt32 @params); // UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTextureParameterfv")]
            internal static partial void GetTextureParameterfv(UInt32 texture, OpenGL.GetTextureParameter pname, ref Single @params); // Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTextureParameteriv")]
            internal static partial void GetTextureParameteriv(UInt32 texture, OpenGL.GetTextureParameter pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTextureParameterIiv")]
            internal static partial void GetTextureParameterIiv(UInt32 texture, OpenGL.GetTextureParameter pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTextureParameterIuiv")]
            internal static partial void GetTextureParameterIuiv(UInt32 texture, OpenGL.GetTextureParameter pname, ref UInt32 @params); // UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTextureSubImage")]
            internal static partial void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, out IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTransformFeedbackiv")]
            internal static partial void GetTransformFeedbackiv(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, ref Int32 param); // Int32[] param);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTransformFeedbacki_v")]
            internal static partial void GetTransformFeedbacki_v(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, UInt32 index, ref Int32 param); // Int32[] param);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTransformFeedbacki64_v")]
            internal static partial void GetTransformFeedbacki64_v(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, UInt32 index, ref Int64 param); // Int64[] param);
            [LibraryImport(Gl.Library, EntryPoint = "glGetTransformFeedbackVarying")]
            internal static partial void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, ref Int32 length, ref Int32 size, ref OpenGL.ActiveAttribType type, byte[] name); // Int32[] length, Int32[] size, out OpenGL.ActiveAttribType[] type, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetUniformfv")]
            internal static partial void GetUniformfv(UInt32 program, Int32 location, ref Single @params); // Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetUniformiv")]
            internal static partial void GetUniformiv(UInt32 program, Int32 location, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetUniformuiv")]
            internal static partial void GetUniformuiv(UInt32 program, Int32 location, ref UInt32 @params); // UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetUniformdv")]
            internal static partial void GetUniformdv(UInt32 program, Int32 location, ref Double @params); // Double[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetnUniformfv")]
            internal static partial void GetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetnUniformiv")]
            internal static partial void GetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetnUniformuiv")]
            internal static partial void GetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetnUniformdv")]
            internal static partial void GetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, Double[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetUniformBlockIndex", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial UInt32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            [LibraryImport(Gl.Library, EntryPoint = "glGetUniformIndices", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, UInt32[] uniformIndices);
            [LibraryImport(Gl.Library, EntryPoint = "glGetUniformLocation", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial Int32 GetUniformLocation(UInt32 program, String name);
            [LibraryImport(Gl.Library, EntryPoint = "glGetUniformSubroutineuiv")]
            internal static partial void GetUniformSubroutineuiv(OpenGL.ShaderType shadertype, Int32 location, ref UInt32 values); // UInt32[] values);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexArrayIndexed64iv")]
            internal static partial void GetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, OpenGL.VertexAttribParameter pname, ref Int64 param); // Int64[] param);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexArrayIndexediv")]
            internal static partial void GetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, OpenGL.VertexAttribParameter pname, ref Int32 param); // Int32[] param);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexArrayiv")]
            internal static partial void GetVertexArrayiv(UInt32 vaobj, OpenGL.VertexAttribParameter pname, ref Int32 param); // Int32[] param);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexAttribdv")]
            internal static partial void GetVertexAttribdv(UInt32 index, OpenGL.VertexAttribParameter pname, ref Double @params); // Double[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexAttribfv")]
            internal static partial void GetVertexAttribfv(UInt32 index, OpenGL.VertexAttribParameter pname, ref Single @params); // Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexAttribiv")]
            internal static partial void GetVertexAttribiv(UInt32 index, OpenGL.VertexAttribParameter pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexAttribIiv")]
            internal static partial void GetVertexAttribIiv(UInt32 index, OpenGL.VertexAttribParameter pname, ref Int32 @params); // Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexAttribIuiv")]
            internal static partial void GetVertexAttribIuiv(UInt32 index, OpenGL.VertexAttribParameter pname, ref UInt32 @params); // UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexAttribLdv")]
            internal static partial void GetVertexAttribLdv(UInt32 index, OpenGL.VertexAttribParameter pname, ref Double @params); // Double[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glGetVertexAttribPointerv")]
            internal static partial void GetVertexAttribPointerv(UInt32 index, OpenGL.VertexAttribPointerParameter pname, out IntPtr pointer);
            [LibraryImport(Gl.Library, EntryPoint = "glHint")]
            internal static partial void Hint(OpenGL.HintTarget target, OpenGL.HintMode mode);
            [LibraryImport(Gl.Library, EntryPoint = "glInvalidateBufferData")]
            internal static partial void InvalidateBufferData(UInt32 buffer);
            [LibraryImport(Gl.Library, EntryPoint = "glInvalidateBufferSubData")]
            internal static partial void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);
            [LibraryImport(Gl.Library, EntryPoint = "glInvalidateFramebuffer")]
            internal static partial void InvalidateFramebuffer(OpenGL.FramebufferTarget target, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments);
            [LibraryImport(Gl.Library, EntryPoint = "glInvalidateNamedFramebufferData")]
            internal static partial void InvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments);
            [LibraryImport(Gl.Library, EntryPoint = "glInvalidateSubFramebuffer")]
            internal static partial void InvalidateSubFramebuffer(OpenGL.FramebufferTarget target, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glInvalidateNamedFramebufferSubData")]
            internal static partial void InvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glInvalidateTexImage")]
            internal static partial void InvalidateTexImage(UInt32 texture, Int32 level);
            [LibraryImport(Gl.Library, EntryPoint = "glInvalidateTexSubImage")]
            internal static partial void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);
            [LibraryImport(Gl.Library, EntryPoint = "glIsBuffer")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsBuffer(UInt32 buffer);
            [LibraryImport(Gl.Library, EntryPoint = "glIsEnabled")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsEnabled(OpenGL.EnableCap cap);
            [LibraryImport(Gl.Library, EntryPoint = "glIsEnabledi")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsEnabledi(OpenGL.EnableCap cap, UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glIsFramebuffer")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsFramebuffer(UInt32 framebuffer);
            [LibraryImport(Gl.Library, EntryPoint = "glIsProgram")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsProgram(UInt32 program);
            [LibraryImport(Gl.Library, EntryPoint = "glIsProgramPipeline")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsProgramPipeline(UInt32 pipeline);
            [LibraryImport(Gl.Library, EntryPoint = "glIsQuery")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsQuery(UInt32 id);
            [LibraryImport(Gl.Library, EntryPoint = "glIsRenderbuffer")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsRenderbuffer(UInt32 renderbuffer);
            [LibraryImport(Gl.Library, EntryPoint = "glIsSampler")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsSampler(UInt32 id);
            [LibraryImport(Gl.Library, EntryPoint = "glIsShader")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsShader(UInt32 shader);
            [LibraryImport(Gl.Library, EntryPoint = "glIsSync")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsSync(IntPtr sync);
            [LibraryImport(Gl.Library, EntryPoint = "glIsTexture")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsTexture(UInt32 texture);
            [LibraryImport(Gl.Library, EntryPoint = "glIsTransformFeedback")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsTransformFeedback(UInt32 id);
            [LibraryImport(Gl.Library, EntryPoint = "glIsVertexArray")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean IsVertexArray(UInt32 array);
            [LibraryImport(Gl.Library, EntryPoint = "glLineWidth")]
            internal static partial void LineWidth(Single width);
            [LibraryImport(Gl.Library, EntryPoint = "glLinkProgram")]
            internal static partial void LinkProgram(UInt32 program);
            [LibraryImport(Gl.Library, EntryPoint = "glLogicOp")]
            internal static partial void LogicOp(OpenGL.LogicOp opcode);
            [LibraryImport(Gl.Library, EntryPoint = "glMapBuffer")]
            internal static partial IntPtr MapBuffer(OpenGL.BufferTarget target, OpenGL.BufferAccess access);
            [LibraryImport(Gl.Library, EntryPoint = "glMapNamedBuffer")]
            internal static partial IntPtr MapNamedBuffer(UInt32 buffer, OpenGL.BufferAccess access);
            [LibraryImport(Gl.Library, EntryPoint = "glMapBufferRange")]
            internal static partial IntPtr MapBufferRange(OpenGL.BufferTarget target, IntPtr offset, IntPtr length, OpenGL.BufferAccessMask access);
            [LibraryImport(Gl.Library, EntryPoint = "glMapNamedBufferRange")]
            internal static partial IntPtr MapNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length, UInt32 access);
            [LibraryImport(Gl.Library, EntryPoint = "glMemoryBarrier")]
            internal static partial void MemoryBarrier(UInt32 barriers);
            [LibraryImport(Gl.Library, EntryPoint = "glMemoryBarrierByRegion")]
            internal static partial void MemoryBarrierByRegion(UInt32 barriers);
            [LibraryImport(Gl.Library, EntryPoint = "glMinSampleShading")]
            internal static partial void MinSampleShading(Single value);
            [LibraryImport(Gl.Library, EntryPoint = "glMultiDrawArrays")]
            internal static partial void MultiDrawArrays(OpenGL.BeginMode mode, Int32[] first, Int32[] count, Int32 drawcount);
            [LibraryImport(Gl.Library, EntryPoint = "glMultiDrawArraysIndirect")]
            internal static partial void MultiDrawArraysIndirect(OpenGL.BeginMode mode, IntPtr indirect, Int32 drawcount, Int32 stride);
            [LibraryImport(Gl.Library, EntryPoint = "glMultiDrawElements")]
            internal static partial void MultiDrawElements(OpenGL.BeginMode mode, Int32[] count, OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount);
            [LibraryImport(Gl.Library, EntryPoint = "glMultiDrawElementsBaseVertex")]
            internal static partial void MultiDrawElementsBaseVertex(OpenGL.BeginMode mode, Int32[] count, OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32[] basevertex);
            [LibraryImport(Gl.Library, EntryPoint = "glMultiDrawElementsIndirect")]
            internal static partial void MultiDrawElementsIndirect(OpenGL.BeginMode mode, OpenGL.DrawElementsType type, IntPtr indirect, Int32 drawcount, Int32 stride);
            [LibraryImport(Gl.Library, EntryPoint = "glObjectLabel", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial void ObjectLabel(OpenGL.ObjectLabel identifier, UInt32 name, Int32 length, String label);
            [LibraryImport(Gl.Library, EntryPoint = "glObjectPtrLabel", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            [LibraryImport(Gl.Library, EntryPoint = "glPatchParameteri")]
            internal static partial void PatchParameteri(Int32 pname, Int32 value);
            [LibraryImport(Gl.Library, EntryPoint = "glPatchParameterfv")]
            internal static partial void PatchParameterfv(Int32 pname, Single[] values);
            [LibraryImport(Gl.Library, EntryPoint = "glPixelStoref")]
            internal static partial void PixelStoref(OpenGL.PixelStoreParameter pname, Single param);
            [LibraryImport(Gl.Library, EntryPoint = "glPixelStorei")]
            internal static partial void PixelStorei(OpenGL.PixelStoreParameter pname, Int32 param);
            [LibraryImport(Gl.Library, EntryPoint = "glPointParameterf")]
            internal static partial void PointParameterf(OpenGL.PointParameterName pname, Single param);
            [LibraryImport(Gl.Library, EntryPoint = "glPointParameteri")]
            internal static partial void PointParameteri(OpenGL.PointParameterName pname, Int32 param);
            [LibraryImport(Gl.Library, EntryPoint = "glPointParameterfv")]
            internal static partial void PointParameterfv(OpenGL.PointParameterName pname, Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glPointParameteriv")]
            internal static partial void PointParameteriv(OpenGL.PointParameterName pname, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glPointSize")]
            internal static partial void PointSize(Single size);
            [LibraryImport(Gl.Library, EntryPoint = "glPolygonMode")]
            internal static partial void PolygonMode(OpenGL.MaterialFace face, OpenGL.PolygonMode mode);
            [LibraryImport(Gl.Library, EntryPoint = "glPolygonOffset")]
            internal static partial void PolygonOffset(Single factor, Single units);
            [LibraryImport(Gl.Library, EntryPoint = "glPrimitiveRestartIndex")]
            internal static partial void PrimitiveRestartIndex(UInt32 index);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramBinary")]
            internal static partial void ProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramParameteri")]
            internal static partial void ProgramParameteri(UInt32 program, OpenGL.Version32 pname, Int32 value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform1f")]
            internal static partial void ProgramUniform1f(UInt32 program, Int32 location, Single v0);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform2f")]
            internal static partial void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform3f")]
            internal static partial void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform4f")]
            internal static partial void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform1i")]
            internal static partial void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform2i")]
            internal static partial void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform3i")]
            internal static partial void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform4i")]
            internal static partial void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform1ui")]
            internal static partial void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform2ui")]
            internal static partial void ProgramUniform2ui(UInt32 program, Int32 location, Int32 v0, UInt32 v1);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform3ui")]
            internal static partial void ProgramUniform3ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, UInt32 v2);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform4ui")]
            internal static partial void ProgramUniform4ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, UInt32 v3);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform1fv")]
            internal static partial void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform2fv")]
            internal static partial void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform3fv")]
            internal static partial void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform4fv")]
            internal static partial void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform1iv")]
            internal static partial void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform2iv")]
            internal static partial void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform3iv")]
            internal static partial void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform4iv")]
            internal static partial void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform1uiv")]
            internal static partial void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform2uiv")]
            internal static partial void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform3uiv")]
            internal static partial void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniform4uiv")]
            internal static partial void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniformMatrix2fv")]
            internal static partial void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniformMatrix3fv")]
            internal static partial void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniformMatrix4fv")]
            internal static partial void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniformMatrix2x3fv")]
            internal static partial void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniformMatrix3x2fv")]
            internal static partial void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniformMatrix2x4fv")]
            internal static partial void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniformMatrix4x2fv")]
            internal static partial void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniformMatrix3x4fv")]
            internal static partial void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProgramUniformMatrix4x3fv")]
            internal static partial void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glProvokingVertex")]
            internal static partial void ProvokingVertex(OpenGL.ProvokingVertexMode provokeMode);
            [LibraryImport(Gl.Library, EntryPoint = "glQueryCounter")]
            internal static partial void QueryCounter(UInt32 id, OpenGL.QueryTarget target);
            [LibraryImport(Gl.Library, EntryPoint = "glReadBuffer")]
            internal static partial void ReadBuffer(OpenGL.ReadBufferMode mode);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedFramebufferReadBuffer")]
            internal static partial void NamedFramebufferReadBuffer(OpenGL.ReadBufferMode framebuffer, OpenGL.BeginMode mode);
            [LibraryImport(Gl.Library, EntryPoint = "glReadPixels")]
            internal static partial void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glReadnPixels")]
            internal static partial void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, Int32[] data);
            [LibraryImport(Gl.Library, EntryPoint = "glRenderbufferStorage")]
            internal static partial void RenderbufferStorage(OpenGL.RenderbufferTarget target, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedRenderbufferStorage")]
            internal static partial void NamedRenderbufferStorage(UInt32 renderbuffer, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glRenderbufferStorageMultisample")]
            internal static partial void RenderbufferStorageMultisample(OpenGL.RenderbufferTarget target, Int32 samples, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glNamedRenderbufferStorageMultisample")]
            internal static partial void NamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glSampleCoverage")]
            internal static partial void SampleCoverage(Single value, [MarshalAs(UnmanagedType.Bool)]Boolean invert);
            [LibraryImport(Gl.Library, EntryPoint = "glSampleMaski")]
            internal static partial void SampleMaski(UInt32 maskNumber, UInt32 mask);
            [LibraryImport(Gl.Library, EntryPoint = "glSamplerParameterf")]
            internal static partial void SamplerParameterf(UInt32 sampler, OpenGL.TextureParameterName pname, Single param);
            [LibraryImport(Gl.Library, EntryPoint = "glSamplerParameteri")]
            internal static partial void SamplerParameteri(UInt32 sampler, OpenGL.TextureParameterName pname, Int32 param);
            [LibraryImport(Gl.Library, EntryPoint = "glSamplerParameterfv")]
            internal static partial void SamplerParameterfv(UInt32 sampler, OpenGL.TextureParameterName pname, Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glSamplerParameteriv")]
            internal static partial void SamplerParameteriv(UInt32 sampler, OpenGL.TextureParameterName pname, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glSamplerParameterIiv")]
            internal static partial void SamplerParameterIiv(UInt32 sampler, OpenGL.TextureParameterName pname, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glSamplerParameterIuiv")]
            internal static partial void SamplerParameterIuiv(UInt32 sampler, OpenGL.TextureParameterName pname, UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glScissor")]
            internal static partial void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glScissorArrayv")]
            internal static partial void ScissorArrayv(UInt32 first, Int32 count, Int32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glScissorIndexed")]
            internal static partial void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glScissorIndexedv")]
            internal static partial void ScissorIndexedv(UInt32 index, Int32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glShaderBinary")]
            internal static partial void ShaderBinary(Int32 count, UInt32[] shaders, Int32 binaryFormat, IntPtr binary, Int32 length);
            [LibraryImport(Gl.Library, EntryPoint = "glShaderSource", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32[] length);
            [LibraryImport(Gl.Library, EntryPoint = "glShaderStorageBlockBinding")]
            internal static partial void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);
            [LibraryImport(Gl.Library, EntryPoint = "glStencilFunc")]
            internal static partial void StencilFunc(OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);
            [LibraryImport(Gl.Library, EntryPoint = "glStencilFuncSeparate")]
            internal static partial void StencilFuncSeparate(OpenGL.StencilFace face, OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);
            [LibraryImport(Gl.Library, EntryPoint = "glStencilMask")]
            internal static partial void StencilMask(UInt32 mask);
            [LibraryImport(Gl.Library, EntryPoint = "glStencilMaskSeparate")]
            internal static partial void StencilMaskSeparate(OpenGL.StencilFace face, UInt32 mask);
            [LibraryImport(Gl.Library, EntryPoint = "glStencilOp")]
            internal static partial void StencilOp(OpenGL.StencilOp sfail, OpenGL.StencilOp dpfail, OpenGL.StencilOp dppass);
            [LibraryImport(Gl.Library, EntryPoint = "glStencilOpSeparate")]
            internal static partial void StencilOpSeparate(OpenGL.StencilFace face, OpenGL.StencilOp sfail, OpenGL.StencilOp dpfail, OpenGL.StencilOp dppass);
            [LibraryImport(Gl.Library, EntryPoint = "glTexBuffer")]
            internal static partial void TexBuffer(OpenGL.TextureBufferTarget target, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureBuffer")]
            internal static partial void TextureBuffer(UInt32 texture, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);
            [LibraryImport(Gl.Library, EntryPoint = "glTexBufferRange")]
            internal static partial void TexBufferRange(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, IntPtr size);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureBufferRange")]
            internal static partial void TextureBufferRange(UInt32 texture, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, Int32 size);
            [LibraryImport(Gl.Library, EntryPoint = "glTexImage1D")]
            internal static partial void TexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glTexImage2D")]
            internal static partial void TexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glTexImage2DMultisample")]
            internal static partial void TexImage2DMultisample(OpenGL.TextureTargetMultisample target, Int32 samples, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, [MarshalAs(UnmanagedType.Bool)]Boolean fixedsamplelocations);
            [LibraryImport(Gl.Library, EntryPoint = "glTexImage3D")]
            internal static partial void TexImage3D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);
            [LibraryImport(Gl.Library, EntryPoint = "glTexImage3DMultisample")]
            internal static partial void TexImage3DMultisample(OpenGL.TextureTargetMultisample target, Int32 samples, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, [MarshalAs(UnmanagedType.Bool)]Boolean fixedsamplelocations);
            [LibraryImport(Gl.Library, EntryPoint = "glTexParameterf")]
            internal static partial void TexParameterf(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Single param);
            [LibraryImport(Gl.Library, EntryPoint = "glTexParameteri")]
            internal static partial void TexParameteri(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32 param);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureParameterf")]
            internal static partial void TextureParameterf(UInt32 texture, OpenGL.TextureParameter pname, Single param);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureParameteri")]
            internal static partial void TextureParameteri(UInt32 texture, OpenGL.TextureParameter pname, Int32 param);
            [LibraryImport(Gl.Library, EntryPoint = "glTexParameterfv")]
            internal static partial void TexParameterfv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Single[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glTexParameteriv")]
            internal static partial void TexParameteriv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glTexParameterIiv")]
            internal static partial void TexParameterIiv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glTexParameterIuiv")]
            internal static partial void TexParameterIuiv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureParameterfv")]
            internal static partial void TextureParameterfv(UInt32 texture, OpenGL.TextureParameter pname, Single[] paramtexture);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureParameteriv")]
            internal static partial void TextureParameteriv(UInt32 texture, OpenGL.TextureParameter pname, Int32[] param);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureParameterIiv")]
            internal static partial void TextureParameterIiv(UInt32 texture, OpenGL.TextureParameter pname, Int32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureParameterIuiv")]
            internal static partial void TextureParameterIuiv(UInt32 texture, OpenGL.TextureParameter pname, UInt32[] @params);
            [LibraryImport(Gl.Library, EntryPoint = "glTexStorage1D")]
            internal static partial void TexStorage1D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureStorage1D")]
            internal static partial void TextureStorage1D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width);
            [LibraryImport(Gl.Library, EntryPoint = "glTexStorage2D")]
            internal static partial void TexStorage2D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureStorage2D")]
            internal static partial void TextureStorage2D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glTexStorage2DMultisample")]
            internal static partial void TexStorage2DMultisample(OpenGL.TextureTarget target, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, [MarshalAs(UnmanagedType.Bool)]Boolean fixedsamplelocations);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureStorage2DMultisample")]
            internal static partial void TextureStorage2DMultisample(UInt32 texture, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, [MarshalAs(UnmanagedType.Bool)]Boolean fixedsamplelocations);
            [LibraryImport(Gl.Library, EntryPoint = "glTexStorage3D")]
            internal static partial void TexStorage3D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureStorage3D")]
            internal static partial void TextureStorage3D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);
            [LibraryImport(Gl.Library, EntryPoint = "glTexStorage3DMultisample")]
            internal static partial void TexStorage3DMultisample(OpenGL.TextureTarget target, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, [MarshalAs(UnmanagedType.Bool)]Boolean fixedsamplelocations);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureStorage3DMultisample")]
            internal static partial void TextureStorage3DMultisample(UInt32 texture, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, [MarshalAs(UnmanagedType.Bool)]Boolean fixedsamplelocations);
            [LibraryImport(Gl.Library, EntryPoint = "glTexSubImage1D")]
            internal static partial void TexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureSubImage1D")]
            internal static partial void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glTexSubImage2D")]
            internal static partial void TexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureSubImage2D")]
            internal static partial void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glTexSubImage3D")]
            internal static partial void TexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureSubImage3D")]
            internal static partial void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
            [LibraryImport(Gl.Library, EntryPoint = "glTextureBarrier")]
            internal static partial void TextureBarrier();
            [LibraryImport(Gl.Library, EntryPoint = "glTextureView")]
            internal static partial void TextureView(UInt32 texture, OpenGL.TextureTarget target, UInt32 origtexture, OpenGL.PixelInternalFormat internalFormat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);
            [LibraryImport(Gl.Library, EntryPoint = "glTransformFeedbackBufferBase")]
            internal static partial void TransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);
            [LibraryImport(Gl.Library, EntryPoint = "glTransformFeedbackBufferRange")]
            internal static partial void TransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, Int32 size);
            [LibraryImport(Gl.Library, EntryPoint = "glTransformFeedbackVaryings", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenGL.TransformFeedbackMode bufferMode);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform1f")]
            internal static partial void Uniform1f(Int32 location, Single v0);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform2f")]
            internal static partial void Uniform2f(Int32 location, Single v0, Single v1);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform3f")]
            internal static partial void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform4f")]
            internal static partial void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform1i")]
            internal static partial void Uniform1i(Int32 location, Int32 v0);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform2i")]
            internal static partial void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform3i")]
            internal static partial void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform4i")]
            internal static partial void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform1ui")]
            internal static partial void Uniform1ui(Int32 location, UInt32 v0);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform2ui")]
            internal static partial void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform3ui")]
            internal static partial void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform4ui")]
            internal static partial void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform1fv")]
            internal static partial void Uniform1fv(Int32 location, Int32 count, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform2fv")]
            internal static partial void Uniform2fv(Int32 location, Int32 count, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform3fv")]
            internal static partial void Uniform3fv(Int32 location, Int32 count, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform4fv")]
            internal static partial void Uniform4fv(Int32 location, Int32 count, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform1iv")]
            internal static partial void Uniform1iv(Int32 location, Int32 count, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform2iv")]
            internal static partial void Uniform2iv(Int32 location, Int32 count, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform3iv")]
            internal static partial void Uniform3iv(Int32 location, Int32 count, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform4iv")]
            internal static partial void Uniform4iv(Int32 location, Int32 count, Int32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform1uiv")]
            internal static partial void Uniform1uiv(Int32 location, Int32 count, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform2uiv")]
            internal static partial void Uniform2uiv(Int32 location, Int32 count, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform3uiv")]
            internal static partial void Uniform3uiv(Int32 location, Int32 count, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniform4uiv")]
            internal static partial void Uniform4uiv(Int32 location, Int32 count, UInt32[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformMatrix2fv")]
            internal static partial void UniformMatrix2fv(Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformMatrix3fv")]
            internal static partial void UniformMatrix3fv(Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformMatrix4fv")]
            internal static partial void UniformMatrix4fv(Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformMatrix2x3fv")]
            internal static partial void UniformMatrix2x3fv(Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformMatrix3x2fv")]
            internal static partial void UniformMatrix3x2fv(Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformMatrix2x4fv")]
            internal static partial void UniformMatrix2x4fv(Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformMatrix4x2fv")]
            internal static partial void UniformMatrix4x2fv(Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformMatrix3x4fv")]
            internal static partial void UniformMatrix3x4fv(Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformMatrix4x3fv")]
            internal static partial void UniformMatrix4x3fv(Int32 location, Int32 count, [MarshalAs(UnmanagedType.Bool)]Boolean transpose, Single[] value);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformBlockBinding")]
            internal static partial void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
            [LibraryImport(Gl.Library, EntryPoint = "glUniformSubroutinesuiv")]
            internal static partial void UniformSubroutinesuiv(OpenGL.ShaderType shadertype, Int32 count, UInt32[] indices);
            [LibraryImport(Gl.Library, EntryPoint = "glUnmapBuffer")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean UnmapBuffer(OpenGL.BufferTarget target);
            [LibraryImport(Gl.Library, EntryPoint = "glUnmapNamedBuffer")][return: MarshalAs(UnmanagedType.Bool)]
            internal static partial Boolean UnmapNamedBuffer(UInt32 buffer);
            [LibraryImport(Gl.Library, EntryPoint = "glUseProgram")]
            internal static partial void UseProgram(UInt32 program);
            [LibraryImport(Gl.Library, EntryPoint = "glUseProgramStages")]
            internal static partial void UseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);
            [LibraryImport(Gl.Library, EntryPoint = "glValidateProgram")]
            internal static partial void ValidateProgram(UInt32 program);
            [LibraryImport(Gl.Library, EntryPoint = "glValidateProgramPipeline")]
            internal static partial void ValidateProgramPipeline(UInt32 pipeline);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexArrayElementBuffer")]
            internal static partial void VertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib1f")]
            internal static partial void VertexAttrib1f(UInt32 index, Single v0);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib1s")]
            internal static partial void VertexAttrib1s(UInt32 index, Int16 v0);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib1d")]
            internal static partial void VertexAttrib1d(UInt32 index, Double v0);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI1i")]
            internal static partial void VertexAttribI1i(UInt32 index, Int32 v0);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI1ui")]
            internal static partial void VertexAttribI1ui(UInt32 index, UInt32 v0);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib2f")]
            internal static partial void VertexAttrib2f(UInt32 index, Single v0, Single v1);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib2s")]
            internal static partial void VertexAttrib2s(UInt32 index, Int16 v0, Int16 v1);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib2d")]
            internal static partial void VertexAttrib2d(UInt32 index, Double v0, Double v1);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI2i")]
            internal static partial void VertexAttribI2i(UInt32 index, Int32 v0, Int32 v1);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI2ui")]
            internal static partial void VertexAttribI2ui(UInt32 index, UInt32 v0, UInt32 v1);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib3f")]
            internal static partial void VertexAttrib3f(UInt32 index, Single v0, Single v1, Single v2);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib3s")]
            internal static partial void VertexAttrib3s(UInt32 index, Int16 v0, Int16 v1, Int16 v2);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib3d")]
            internal static partial void VertexAttrib3d(UInt32 index, Double v0, Double v1, Double v2);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI3i")]
            internal static partial void VertexAttribI3i(UInt32 index, Int32 v0, Int32 v1, Int32 v2);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI3ui")]
            internal static partial void VertexAttribI3ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4f")]
            internal static partial void VertexAttrib4f(UInt32 index, Single v0, Single v1, Single v2, Single v3);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4s")]
            internal static partial void VertexAttrib4s(UInt32 index, Int16 v0, Int16 v1, Int16 v2, Int16 v3);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4d")]
            internal static partial void VertexAttrib4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4Nub")]
            internal static partial void VertexAttrib4Nub(UInt32 index, Byte v0, Byte v1, Byte v2, Byte v3);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI4i")]
            internal static partial void VertexAttribI4i(UInt32 index, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI4ui")]
            internal static partial void VertexAttribI4ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribL1d")]
            internal static partial void VertexAttribL1d(UInt32 index, Double v0);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribL2d")]
            internal static partial void VertexAttribL2d(UInt32 index, Double v0, Double v1);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribL3d")]
            internal static partial void VertexAttribL3d(UInt32 index, Double v0, Double v1, Double v2);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribL4d")]
            internal static partial void VertexAttribL4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib1fv")]
            internal static partial void VertexAttrib1fv(UInt32 index, Single[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib1sv")]
            internal static partial void VertexAttrib1sv(UInt32 index, Int16[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib1dv")]
            internal static partial void VertexAttrib1dv(UInt32 index, Double[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI1iv")]
            internal static partial void VertexAttribI1iv(UInt32 index, Int32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI1uiv")]
            internal static partial void VertexAttribI1uiv(UInt32 index, UInt32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib2fv")]
            internal static partial void VertexAttrib2fv(UInt32 index, Single[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib2sv")]
            internal static partial void VertexAttrib2sv(UInt32 index, Int16[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib2dv")]
            internal static partial void VertexAttrib2dv(UInt32 index, Double[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI2iv")]
            internal static partial void VertexAttribI2iv(UInt32 index, Int32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI2uiv")]
            internal static partial void VertexAttribI2uiv(UInt32 index, UInt32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib3fv")]
            internal static partial void VertexAttrib3fv(UInt32 index, Single[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib3sv")]
            internal static partial void VertexAttrib3sv(UInt32 index, Int16[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib3dv")]
            internal static partial void VertexAttrib3dv(UInt32 index, Double[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI3iv")]
            internal static partial void VertexAttribI3iv(UInt32 index, Int32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI3uiv")]
            internal static partial void VertexAttribI3uiv(UInt32 index, UInt32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4fv")]
            internal static partial void VertexAttrib4fv(UInt32 index, Single[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4sv")]
            internal static partial void VertexAttrib4sv(UInt32 index, Int16[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4dv")]
            internal static partial void VertexAttrib4dv(UInt32 index, Double[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4iv")]
            internal static partial void VertexAttrib4iv(UInt32 index, Int32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4bv")]
            internal static partial void VertexAttrib4bv(UInt32 index, SByte[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4ubv")]
            internal static partial void VertexAttrib4ubv(UInt32 index, Byte[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4usv")]
            internal static partial void VertexAttrib4usv(UInt32 index, UInt16[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4uiv")]
            internal static partial void VertexAttrib4uiv(UInt32 index, UInt32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4Nbv")]
            internal static partial void VertexAttrib4Nbv(UInt32 index, SByte[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4Nsv")]
            internal static partial void VertexAttrib4Nsv(UInt32 index, Int16[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4Niv")]
            internal static partial void VertexAttrib4Niv(UInt32 index, Int32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4Nubv")]
            internal static partial void VertexAttrib4Nubv(UInt32 index, Byte[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4Nusv")]
            internal static partial void VertexAttrib4Nusv(UInt32 index, UInt16[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttrib4Nuiv")]
            internal static partial void VertexAttrib4Nuiv(UInt32 index, UInt32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI4bv")]
            internal static partial void VertexAttribI4bv(UInt32 index, SByte[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI4ubv")]
            internal static partial void VertexAttribI4ubv(UInt32 index, Byte[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI4sv")]
            internal static partial void VertexAttribI4sv(UInt32 index, Int16[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI4usv")]
            internal static partial void VertexAttribI4usv(UInt32 index, UInt16[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI4iv")]
            internal static partial void VertexAttribI4iv(UInt32 index, Int32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribI4uiv")]
            internal static partial void VertexAttribI4uiv(UInt32 index, UInt32[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribL1dv")]
            internal static partial void VertexAttribL1dv(UInt32 index, Double[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribL2dv")]
            internal static partial void VertexAttribL2dv(UInt32 index, Double[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribL3dv")]
            internal static partial void VertexAttribL3dv(UInt32 index, Double[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribL4dv")]
            internal static partial void VertexAttribL4dv(UInt32 index, Double[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribP1ui")]
            internal static partial void VertexAttribP1ui(UInt32 index, OpenGL.VertexAttribPType type, [MarshalAs(UnmanagedType.Bool)]Boolean normalized, UInt32 value);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribP2ui")]
            internal static partial void VertexAttribP2ui(UInt32 index, OpenGL.VertexAttribPType type, [MarshalAs(UnmanagedType.Bool)]Boolean normalized, UInt32 value);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribP3ui")]
            internal static partial void VertexAttribP3ui(UInt32 index, OpenGL.VertexAttribPType type, [MarshalAs(UnmanagedType.Bool)]Boolean normalized, UInt32 value);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribP4ui")]
            internal static partial void VertexAttribP4ui(UInt32 index, OpenGL.VertexAttribPType type, [MarshalAs(UnmanagedType.Bool)]Boolean normalized, UInt32 value);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribBinding")]
            internal static partial void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexArrayAttribBinding")]
            internal static partial void VertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribDivisor")]
            internal static partial void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribFormat")]
            internal static partial void VertexAttribFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, [MarshalAs(UnmanagedType.Bool)]Boolean normalized, UInt32 relativeoffset);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribIFormat")]
            internal static partial void VertexAttribIFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribLFormat")]
            internal static partial void VertexAttribLFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexArrayAttribFormat")]
            internal static partial void VertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, [MarshalAs(UnmanagedType.Bool)]Boolean normalized, UInt32 relativeoffset);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexArrayAttribIFormat")]
            internal static partial void VertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexArrayAttribLFormat")]
            internal static partial void VertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribPointer")]
            internal static partial void VertexAttribPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, [MarshalAs(UnmanagedType.Bool)]Boolean normalized, Int32 stride, IntPtr pointer);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribIPointer")]
            internal static partial void VertexAttribIPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexAttribLPointer")]
            internal static partial void VertexAttribLPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexBindingDivisor")]
            internal static partial void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);
            [LibraryImport(Gl.Library, EntryPoint = "glVertexArrayBindingDivisor")]
            internal static partial void VertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);
            [LibraryImport(Gl.Library, EntryPoint = "glViewport")]
            internal static partial void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            [LibraryImport(Gl.Library, EntryPoint = "glViewportArrayv")]
            internal static partial void ViewportArrayv(UInt32 first, Int32 count, Single[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glViewportIndexedf")]
            internal static partial void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);
            [LibraryImport(Gl.Library, EntryPoint = "glViewportIndexedfv")]
            internal static partial void ViewportIndexedfv(UInt32 index, Single[] v);
            [LibraryImport(Gl.Library, EntryPoint = "glWaitSync")]
            internal static partial void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
        }
    }
}
