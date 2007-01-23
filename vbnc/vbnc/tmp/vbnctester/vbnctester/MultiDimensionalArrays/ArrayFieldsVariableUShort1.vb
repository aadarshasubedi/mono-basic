Module ArrayFieldsVariableUShort1
    Dim a As UShort()
    Dim b As UShort(,)
    Dim c As UShort(,,)
    Dim d As UShort(,,,)
    Dim aa() As UShort
    Dim bb(,) As UShort
    Dim cc(,,) As UShort
    Dim dd(,,,) As UShort

    Function Main() As Int32
        Dim result As Int32

        a = New UShort() {}
        b = New UShort(,) {}
        c = New UShort(,,) {}
        d = New UShort(,,,) {}

        aa = New UShort() {}
        bb = New UShort(,) {}
        cc = New UShort(,,) {}
        dd = New UShort(,,,) {}

        result += ArrayVerifier.Verify(a, b, c, d, aa, bb, cc, dd)

        If a.Length <> 0 Then result += ArrayVerifier.Report()
        If b.Length <> 0 Then result += ArrayVerifier.Report()
        If c.Length <> 0 Then result += ArrayVerifier.Report()
        If d.Length <> 0 Then result += ArrayVerifier.Report()

        If aa.Length <> 0 Then result += ArrayVerifier.Report()
        If bb.Length <> 0 Then result += ArrayVerifier.Report()
        If cc.Length <> 0 Then result += ArrayVerifier.Report()
        If dd.Length <> 0 Then result += ArrayVerifier.Report()

        a = New UShort() {}
        b = New UShort(,) {{}}
        c = New UShort(,,) {{{}}}
        d = New UShort(,,,) {{{{}}}}

        aa = New UShort() {}
        bb = New UShort(,) {{}}
        cc = New UShort(,,) {{{}}}
        dd = New UShort(,,,) {{{{}}}}

        result += ArrayVerifier.Verify(a, b, c, d, aa, bb, cc, dd)

        If a.Length <> 0 Then result += ArrayVerifier.Report()
        If b.Length <> 0 Then result += ArrayVerifier.Report()
        If c.Length <> 0 Then result += ArrayVerifier.Report()
        If d.Length <> 0 Then result += ArrayVerifier.Report()

        If aa.Length <> 0 Then result += ArrayVerifier.Report()
        If bb.Length <> 0 Then result += ArrayVerifier.Report()
        If cc.Length <> 0 Then result += ArrayVerifier.Report()
        If dd.Length <> 0 Then result += ArrayVerifier.Report()


        a = New UShort() {1US, 2US}
        b = New UShort(,) {{10US, 11US}, {12US, 13US}}
        c = New UShort(,,) {{{20US, 21US}, {22US, 23US}}, {{24US, 25US}, {26US, 27US}}}
        d = New UShort(,,,) {{{{30US, 31US}, {32US, 33US}}, {{34US, 35US}, {36US, 37US}}}, {{{40US, 41US}, {42US, 43US}}, {{44US, 45US}, {46US, 47US}}}}

        aa = New UShort() {1US, 2US}
        bb = New UShort(,) {{10US, 11US}, {12US, 13US}}
        cc = New UShort(,,) {{{20US, 21US}, {22US, 23US}}, {{24US, 25US}, {26US, 27US}}}
        dd = New UShort(,,,) {{{{30US, 31US}, {32US, 33US}}, {{34US, 35US}, {36US, 37US}}}, {{{40US, 41US}, {42US, 43US}}, {{44US, 45US}, {46US, 47US}}}}

        result += ArrayVerifier.Verify(a, b, c, d, aa, bb, cc, dd)

        If a.Length <> 2 Then result += ArrayVerifier.Report()
        If b.Length <> 4 Then result += ArrayVerifier.Report()
        If c.Length <> 8 Then result += ArrayVerifier.Report()
        If d.Length <> 16 Then result += ArrayVerifier.Report()

        If aa.Length <> 2 Then result += ArrayVerifier.Report()
        If bb.Length <> 4 Then result += ArrayVerifier.Report()
        If cc.Length <> 8 Then result += ArrayVerifier.Report()
        If dd.Length <> 16 Then result += ArrayVerifier.Report()

        a = New UShort() {51US, 52US}
        b = New UShort(,) {{50US, 51US}, {52US, 53US}}
        c = New UShort(,,) {{{60US, 61US}, {62US, 63US}}, {{64US, 65US}, {66US, 67US}}}
        d = New UShort(,,,) {{{{70US, 71US}, {72US, 73US}}, {{74US, 75US}, {76US, 77US}}}, {{{80US, 81US}, {82US, 83US}}, {{84US, 85US}, {86US, 87US}}}}

        aa(0) = 51US
        aa(1) = 52US
        bb(0, 0) = 50US
        bb(0, 1) = 51US
        bb(1, 0) = 52US
        bb(1, 1) = 53US
        cc(0, 0, 0) = 60US
        cc(0, 0, 1) = 61US
        cc(0, 1, 0) = 62US
        cc(0, 1, 1) = 63US
        cc(1, 0, 0) = 64US
        cc(1, 0, 1) = 65US
        cc(1, 1, 0) = 66US
        cc(1, 1, 1) = 67US

        dd(0, 0, 0, 0) = 70US
        dd(0, 0, 0, 1) = 71US
        dd(0, 0, 1, 0) = 72US
        dd(0, 0, 1, 1) = 73US
        dd(0, 1, 0, 0) = 74US
        dd(0, 1, 0, 1) = 75US
        dd(0, 1, 1, 0) = 76US
        dd(0, 1, 1, 1) = 77US

        dd(1, 0, 0, 0) = 80US
        dd(1, 0, 0, 1) = 81US
        dd(1, 0, 1, 0) = 82US
        dd(1, 0, 1, 1) = 83US
        dd(1, 1, 0, 0) = 84US
        dd(1, 1, 0, 1) = 85US
        dd(1, 1, 1, 0) = 86US
        dd(1, 1, 1, 1) = 87US

        result += ArrayVerifier.Verify(a, b, c, d, aa, bb, cc, dd)

        If a.Length <> 2 Then result += ArrayVerifier.Report()
        If b.Length <> 4 Then result += ArrayVerifier.Report()
        If c.Length <> 8 Then result += ArrayVerifier.Report()
        If d.Length <> 16 Then result += ArrayVerifier.Report()

        If aa.Length <> 2 Then result += ArrayVerifier.Report()
        If bb.Length <> 4 Then result += ArrayVerifier.Report()
        If cc.Length <> 8 Then result += ArrayVerifier.Report()
        If dd.Length <> 16 Then result += ArrayVerifier.Report()

        Return result
    End Function

End Module