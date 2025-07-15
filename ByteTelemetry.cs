public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] bufferBytes = new byte[9];
        byte[] bytesValue;

        if (reading > UInt32.MaxValue || reading < Int32.MinValue)
        {
            bufferBytes[0] = 0xf8; //248
            bytesValue = BitConverter.GetBytes(reading);
            bytesValue.CopyTo(bufferBytes, 1);
        }
        else if  (reading > Int32.MaxValue)
        {
            bufferBytes[0] = 0x4; //4
            bytesValue = BitConverter.GetBytes((uint)reading);
            bytesValue.CopyTo(bufferBytes, 1);
        }
        else if (reading > UInt16.MaxValue || reading < Int16.MinValue)
        {
            bufferBytes[0] = 0xfc; //252
            bytesValue = BitConverter.GetBytes((int)reading);
            bytesValue.CopyTo(bufferBytes, 1);
        }
        else if (reading >=0)
        {
            bufferBytes[0] = 0x2; //2
            bytesValue = BitConverter.GetBytes((ushort)reading);
            bytesValue.CopyTo(bufferBytes, 1);
        }
        else
        {
            bufferBytes[0] = 0xfe; //254
            bytesValue = BitConverter.GetBytes((short)reading);
            bytesValue.CopyTo(bufferBytes, 1);
        }

        return bufferBytes;
    }

    public static long FromBuffer(byte[] buffer)
    {
        switch ((sbyte)buffer[0])
        {
            case -8:
                return BitConverter.ToInt64(buffer, 1);
            case -4:
                return BitConverter.ToInt32(buffer, 1);
            case -2:
                return BitConverter.ToInt16(buffer, 1);
            case 2:
                return BitConverter.ToUInt16(buffer, 1);
            case 4:
                return BitConverter.ToUInt32(buffer, 1);
            default:
                return 0;
                
        }
    }
}
