#region License
/*
 * AuthenticationBase.cs
 *
 * The MIT License
 *
 * Copyright (c) 2014 sta.blockhead
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
#endregion

using System;
using System.Collections.Specialized;
using System.Text;

namespace WebSocketSharp.Net
{
  internal abstract class AuthenticationBase
  {
    #region Private Fields

    private AuthenticationSchemes _scheme;

    #endregion

    #region Internal Fields

    internal NameValueCollection Parameters;

    #endregion

    #region Protected Constructors

    protected AuthenticationBase (
      AuthenticationSchemes scheme, NameValueCollection parameters
    )
    {
      _scheme = scheme;
      Parameters = parameters;
    }

    #endregion

    #region Public Properties

    public string Nonce {
      get {
        return Parameters["nonce"];
      }
    }

    public string Opaque {
      get {
        return Parameters["opaque"];
      }
    }

    public string Qop {
      get {
        return Parameters["qop"];
      }
    }

    public string Realm {
      get {
        return Parameters["realm"];
      }
    }

    public AuthenticationSchemes Scheme {
      get {
        return _scheme;
      }
    }

    #endregion
  }
}
