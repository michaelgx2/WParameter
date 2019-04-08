using System;
using System.Numerics;
using Newtonsoft.Json;

[JsonObject(MemberSerialization.Fields)]
public class WFloat
{
    private float[] _val = new float[2];
    private int _current = 0;
    private float _fixer = 1;

    public float Value
    {
        get
        {
            return _val[_current] * _fixer;
        }
        set
        {
            _current++;
            if (_current >= _val.Length)
            {
                _current = 0;
                _fixer *= -1;
            }
            _val[_current] = value * _fixer;
        }
    }

    public WFloat(float val)
    {
        Value = val;
    }

    public WFloat() { }
}

[JsonObject(MemberSerialization.Fields)]
public class WBool
{
    private bool[] _val = new bool[2];
    private int _current = 0;
    private bool _fixer = false;

    public bool Value
    {
        get
        {
            return _fixer ? !_val[_current] : _val[_current];
        }
        set
        {
            _current++;
            if (_current >= _val.Length)
            {
                _current = 0;
                _fixer = !_fixer;
            }
            _val[_current] = _fixer ? !value : value;
        }
    }

    public WBool(bool val)
    {
        Value = val;
    }

    public WBool() { }
}

[JsonObject(MemberSerialization.Fields)]
public class WInt
{
    private int[] _val = new int[2];
    private int _current = 0;
    private int _fixer = 1;

    public int Value
    {
        get
        {
            return _val[_current] * _fixer;
        }
        set
        {
            _current++;
            if (_current >= _val.Length)
            {
                _current = 0;
                _fixer *= -1;
            }
            _val[_current] = value * _fixer;
        }
    }

    public WInt(int val)
    {
        Value = val;
    }

    public WInt() { }
}

[JsonObject(MemberSerialization.Fields)]
public class WBigInt
{
    private BigInteger[] _val = new BigInteger[2];
    private int _current = 0;
    private BigInteger _fixer = 1;

    public BigInteger Value
    {
        get
        {
            return _val[_current] * _fixer;
        }
        set
        {
            _current++;
            if (_current >= _val.Length)
            {
                _current = 0;
                _fixer *= -1;
            }
            _val[_current] = value * _fixer;
        }
    }

    public WBigInt(BigInteger val)
    {
        Value = val;
    }

    public WBigInt() { }
}