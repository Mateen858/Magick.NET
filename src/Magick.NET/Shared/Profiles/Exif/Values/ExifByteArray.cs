﻿// Copyright 2013-2019 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

namespace ImageMagick
{
    /// <summary>
    /// Exif value that contains a <see cref="T:byte[]"/>.
    /// </summary>
    public sealed class ExifByteArray : ExifArrayValue<byte>
    {
        internal ExifByteArray(ExifTag tag, ExifDataType dataType)
            : base(tag, dataType)
        {
        }

        internal static ExifByteArray Create(ExifTag tag, ExifDataType dataType, byte[] value) => new ExifByteArray(tag, dataType) { Value = value };
    }
}
