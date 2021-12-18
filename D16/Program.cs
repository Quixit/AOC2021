﻿// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using D16;

var input = string.Join("",
    "A20D6CE8F00033925A95338B6549C0149E3398DE75817200992531E25F005A18C8C8C0001849FDD43629C293004B001059363936796973BF3699CFF4C6C0068C9D72A1231C339802519F001029C2B9C29700B2573962930298B6B524893ABCCEC2BCD681CC010D005E104EFC7246F5EE7328C22C8400424C2538039239F720E3339940263A98029600A80021B1FE34C69100760B41C86D290A8E180256009C9639896A66533E459148200D5AC0149D4E9AACEF0F66B42696194031F000BCE7002D80A8D60277DC00B20227C807E8001CE0C00A7002DC00F300208044E000E69C00B000974C00C1003DC0089B90C1006F5E009CFC87E7E43F3FBADE77BE14C8032C9350D005662754F9BDFA32D881004B12B1964D7000B689B03254564414C016B004A6D3A6BD0DC61E2C95C6E798EA8A4600B5006EC0008542D8690B80010D89F1461B4F535296B6B305A7A4264029580021D1122146900043A0EC7884200085C598CF064C0129CFD8868024592FEE9D7692FEE9D735009E6BBECE0826842730CD250EEA49AA00C4F4B9C9D36D925195A52C4C362EB8043359AE221733DB4B14D9DCE6636ECE48132E040182D802F30AF22F131087EDD9A20804D27BEFF3FD16C8F53A5B599F4866A78D7898C0139418D00424EBB459915200C0BC01098B527C99F4EB54CF0450014A95863BDD3508038600F44C8B90A0801098F91463D1803D07634433200AB68015299EBF4CF5F27F05C600DCEBCCE3A48BC1008B1801AA0803F0CA1AC6200043A2C4558A710E364CC2D14920041E7C9A7040402E987492DE5327CF66A6A93F8CFB4BE60096006E20008543A8330780010E8931C20DCF4BFF13000A424711C4FB32999EE33351500A66E8492F185AB32091F1841C91BE2FDC53C4E80120C8C67EA7734D2448891804B2819245334372CBB0F080480E00D4C0010E82F102360803B1FA2146D963C300BA696A694A501E589A6C80"
        .Select(HexToBitString));

var packets = new List<Packet>();

for(var i = 0; i < input.Length; i++)
{
    var header = input.Substring(i, 6);
    i += 5; 
    
    var current = new Packet(header);

    if (current.Type == 4)
    {
        var value = "";

        while (input[i] == '1')
        {
            value += input.Substring(i + 1, 4); 

            i += 5;
        }
        
        current.Value = Convert.ToInt32(value, 2);
    }
    else
    {
        if (input[i] == '0')
        {
            var length = input.Substring(i, 15);
            i += 15;
        }
        else
        {
            var quantity = input.Substring(i, 11);
            i += 11;
        }
    }
    
    packets.Add(current);
    i += (i + 1) % 4;//next hex
}


//Console.WriteLine($"{converted}");

string HexToBitString(char character)
{
    switch (character)
    {
        case '0':
            return "0000";
        case '1':
            return "0001";
        case '2':
            return "0010";
        case '3':
            return "0011";
        case '4':
            return "0100";
        case '5':
            return "0101";
        case '6':
            return "0110";
        case '7':
            return "0111";
        case '8':
            return "1000";
        case '9':
            return "1001";
        case 'A':
            return "1010";
        case 'B':
            return "1011";
        case 'C':
            return "1100";
        case 'D':
            return "1101";
        case 'E':
            return "1110";
        case 'F':
            return "1111";
    }
    
    return "FAIL";
}