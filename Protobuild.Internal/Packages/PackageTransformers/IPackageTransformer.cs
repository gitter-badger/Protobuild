﻿namespace Protobuild
{
    public interface IPackageTransformer
    {
        byte[] Transform(string url, string gitReference, string platform, string format);
    }
}

