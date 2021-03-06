// This file was generated based on lib/UnoCore/Source/OpenGL/GLTextureHandle.uno.
// WARNING: Changes might be lost if you edit this file directly.

namespace OpenGL
{
    [global::Uno.Compiler.ExportTargetInterop.DotNetTypeAttribute(null)]
    public struct GLTextureHandle
    {
        public static readonly GLTextureHandle Zero;
        public readonly int _id;

        public GLTextureHandle(int id)
        {
            this._id = id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static bool operator ==(GLTextureHandle left, GLTextureHandle right)
        {
            return left._id == right._id;
        }

        public static bool operator !=(GLTextureHandle left, GLTextureHandle right)
        {
            return left._id != right._id;
        }

        public static explicit operator int(GLTextureHandle handle)
        {
            return handle._id;
        }

        public static explicit operator GLTextureHandle(int handle)
        {
            return new GLTextureHandle(handle);
        }
    }
}
