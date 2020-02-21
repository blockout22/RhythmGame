using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMap : MonoBehaviour
{
    // Start is called before the first frame update
    public static MapInfo load()
    {
        Data d1 = new Data();
        d1.time = 1886;
        d1.spawnTime = 1000;
        d1.distance = Distance.CLOSE;
        d1.spawnAngle = 48;

        Data d2 = new Data();
        d2.time = 3577;
        d2.spawnTime = 1000;
        d2.distance = Distance.CLOSE;
        d2.spawnAngle = 42;

        Data d3 = new Data();
        d3.time = 5427;
        d3.spawnTime = 1000;
        d3.distance = Distance.CLOSE;
        d3.spawnAngle = 83;

        Data d4 = new Data();
        d4.time = 7429;
        d4.spawnTime = 1000;
        d4.distance = Distance.CLOSE;
        d4.spawnAngle = 71;

        Data d5 = new Data();
        d5.time = 9281;
        d5.spawnTime = 1000;
        d5.distance = Distance.CLOSE;
        d5.spawnAngle = 24;

        Data d6 = new Data();
        d6.time = 11134;
        d6.spawnTime = 1000;
        d6.distance = Distance.CLOSE;
        d6.spawnAngle = 43;

        Data d7 = new Data();
        d7.time = 13046;
        d7.spawnTime = 1000;
        d7.distance = Distance.CLOSE;
        d7.spawnAngle = 27;

        Data d8 = new Data();
        d8.time = 14679;
        d8.spawnTime = 1000;
        d8.distance = Distance.CLOSE;
        d8.spawnAngle = 36;

        Data d9 = new Data();
        d9.time = 16563;
        d9.spawnTime = 1000;
        d9.distance = Distance.CLOSE;
        d9.spawnAngle = 14;

        Data d10 = new Data();
        d10.time = 18513;
        d10.spawnTime = 1000;
        d10.distance = Distance.CLOSE;
        d10.spawnAngle = 8;

        Data d11 = new Data();
        d11.time = 20222;
        d11.spawnTime = 1000;
        d11.distance = Distance.CLOSE;
        d11.spawnAngle = 81;

        Data d12 = new Data();
        d12.time = 22031;
        d12.spawnTime = 1000;
        d12.distance = Distance.CLOSE;
        d12.spawnAngle = 11;

        Data d13 = new Data();
        d13.time = 23635;
        d13.spawnTime = 1000;
        d13.distance = Distance.CLOSE;
        d13.spawnAngle = 88;

        Data d14 = new Data();
        d14.time = 25919;
        d14.spawnTime = 1000;
        d14.distance = Distance.CLOSE;
        d14.spawnAngle = 51;

        Data d15 = new Data();
        d15.time = 27560;
        d15.spawnTime = 1000;
        d15.distance = Distance.CLOSE;
        d15.spawnAngle = 79;

        Data d16 = new Data();
        d16.time = 29602;
        d16.spawnTime = 1000;
        d16.distance = Distance.CLOSE;
        d16.spawnAngle = 25;

        Data d17 = new Data();
        d17.time = 31157;
        d17.spawnTime = 1000;
        d17.distance = Distance.CLOSE;
        d17.spawnAngle = 19;

        Data d18 = new Data();
        d18.time = 33327;
        d18.spawnTime = 1000;
        d18.distance = Distance.CLOSE;
        d18.spawnAngle = 78;

        Data d19 = new Data();
        d19.time = 35250;
        d19.spawnTime = 1000;
        d19.distance = Distance.CLOSE;
        d19.spawnAngle = 79;

        Data d20 = new Data();
        d20.time = 36989;
        d20.spawnTime = 1000;
        d20.distance = Distance.CLOSE;
        d20.spawnAngle = 57;

        Data d21 = new Data();
        d21.time = 38917;
        d21.spawnTime = 1000;
        d21.distance = Distance.CLOSE;
        d21.spawnAngle = 44;

        Data d22 = new Data();
        d22.time = 40714;
        d22.spawnTime = 1000;
        d22.distance = Distance.CLOSE;
        d22.spawnAngle = 34;

        Data d23 = new Data();
        d23.time = 42562;
        d23.spawnTime = 1000;
        d23.distance = Distance.CLOSE;
        d23.spawnAngle = 60;

        Data d24 = new Data();
        d24.time = 44453;
        d24.spawnTime = 1000;
        d24.distance = Distance.CLOSE;
        d24.spawnAngle = 4;

        Data d25 = new Data();
        d25.time = 46252;
        d25.spawnTime = 1000;
        d25.distance = Distance.CLOSE;
        d25.spawnAngle = 24;

        Data d26 = new Data();
        d26.time = 48083;
        d26.spawnTime = 1000;
        d26.distance = Distance.CLOSE;
        d26.spawnAngle = 75;

        Data d27 = new Data();
        d27.time = 49945;
        d27.spawnTime = 1000;
        d27.distance = Distance.CLOSE;
        d27.spawnAngle = 29;

        Data d28 = new Data();
        d28.time = 51809;
        d28.spawnTime = 1000;
        d28.distance = Distance.CLOSE;
        d28.spawnAngle = 79;

        Data d29 = new Data();
        d29.time = 53667;
        d29.spawnTime = 1000;
        d29.distance = Distance.CLOSE;
        d29.spawnAngle = 22;

        Data d30 = new Data();
        d30.time = 55576;
        d30.spawnTime = 1000;
        d30.distance = Distance.CLOSE;
        d30.spawnAngle = 27;

        Data d31 = new Data();
        d31.time = 59173;
        d31.spawnTime = 1000;
        d31.distance = Distance.CLOSE;
        d31.spawnAngle = 49;

        Data d32 = new Data();
        d32.time = 61069;
        d32.spawnTime = 1000;
        d32.distance = Distance.CLOSE;
        d32.spawnAngle = 36;

        Data d33 = new Data();
        d33.time = 62744;
        d33.spawnTime = 1000;
        d33.distance = Distance.CLOSE;
        d33.spawnAngle = 11;

        Data d34 = new Data();
        d34.time = 64708;
        d34.spawnTime = 1000;
        d34.distance = Distance.CLOSE;
        d34.spawnAngle = 43;

        Data d35 = new Data();
        d35.time = 66526;
        d35.spawnTime = 1000;
        d35.distance = Distance.CLOSE;
        d35.spawnAngle = 40;

        Data d36 = new Data();
        d36.time = 68413;
        d36.spawnTime = 1000;
        d36.distance = Distance.CLOSE;
        d36.spawnAngle = 48;

        Data d37 = new Data();
        d37.time = 70248;
        d37.spawnTime = 1000;
        d37.distance = Distance.CLOSE;
        d37.spawnAngle = 6;

        Data d38 = new Data();
        d38.time = 72084;
        d38.spawnTime = 1000;
        d38.distance = Distance.CLOSE;
        d38.spawnAngle = 12;

        Data d39 = new Data();
        d39.time = 73948;
        d39.spawnTime = 1000;
        d39.distance = Distance.CLOSE;
        d39.spawnAngle = 58;

        Data d40 = new Data();
        d40.time = 75930;
        d40.spawnTime = 1000;
        d40.distance = Distance.CLOSE;
        d40.spawnAngle = 5;

        Data d41 = new Data();
        d41.time = 77602;
        d41.spawnTime = 1000;
        d41.distance = Distance.CLOSE;
        d41.spawnAngle = 31;

        Data d42 = new Data();
        d42.time = 79433;
        d42.spawnTime = 1000;
        d42.distance = Distance.CLOSE;
        d42.spawnAngle = 13;

        Data d43 = new Data();
        d43.time = 81330;
        d43.spawnTime = 1000;
        d43.distance = Distance.CLOSE;
        d43.spawnAngle = 68;

        Data d44 = new Data();
        d44.time = 83183;
        d44.spawnTime = 1000;
        d44.distance = Distance.CLOSE;
        d44.spawnAngle = 63;

        Data d45 = new Data();
        d45.time = 85046;
        d45.spawnTime = 1000;
        d45.distance = Distance.CLOSE;
        d45.spawnAngle = 72;

        Data d46 = new Data();
        d46.time = 86879;
        d46.spawnTime = 1000;
        d46.distance = Distance.CLOSE;
        d46.spawnAngle = 22;

        Data d47 = new Data();
        d47.time = 88713;
        d47.spawnTime = 1000;
        d47.distance = Distance.CLOSE;
        d47.spawnAngle = 37;

        Data d48 = new Data();
        d48.time = 90615;
        d48.spawnTime = 1000;
        d48.distance = Distance.CLOSE;
        d48.spawnAngle = 60;

        Data d49 = new Data();
        d49.time = 105541;
        d49.spawnTime = 1000;
        d49.distance = Distance.CLOSE;
        d49.spawnAngle = 42;

        Data d50 = new Data();
        d50.time = 107388;
        d50.spawnTime = 1000;
        d50.distance = Distance.CLOSE;
        d50.spawnAngle = 7;

        Data d51 = new Data();
        d51.time = 109083;
        d51.spawnTime = 1000;
        d51.distance = Distance.CLOSE;
        d51.spawnAngle = 52;

        Data d52 = new Data();
        d52.time = 111006;
        d52.spawnTime = 1000;
        d52.distance = Distance.CLOSE;
        d52.spawnAngle = 9;

        Data d53 = new Data();
        d53.time = 112733;
        d53.spawnTime = 1000;
        d53.distance = Distance.CLOSE;
        d53.spawnAngle = 68;

        Data d54 = new Data();
        d54.time = 114569;
        d54.spawnTime = 1000;
        d54.distance = Distance.CLOSE;
        d54.spawnAngle = 89;

        Data d55 = new Data();
        d55.time = 116426;
        d55.spawnTime = 1000;
        d55.distance = Distance.CLOSE;
        d55.spawnAngle = 32;

        Data d56 = new Data();
        d56.time = 118307;
        d56.spawnTime = 1000;
        d56.distance = Distance.CLOSE;
        d56.spawnAngle = 51;

        Data d57 = new Data();
        d57.time = 120121;
        d57.spawnTime = 1000;
        d57.distance = Distance.CLOSE;
        d57.spawnAngle = 74;

        Data d58 = new Data();
        d58.time = 121974;
        d58.spawnTime = 1000;
        d58.distance = Distance.CLOSE;
        d58.spawnAngle = 68;

        Data d59 = new Data();
        d59.time = 123772;
        d59.spawnTime = 1000;
        d59.distance = Distance.CLOSE;
        d59.spawnAngle = 66;

        Data d60 = new Data();
        d60.time = 125698;
        d60.spawnTime = 1000;
        d60.distance = Distance.CLOSE;
        d60.spawnAngle = 81;

        Data d61 = new Data();
        d61.time = 127466;
        d61.spawnTime = 1000;
        d61.distance = Distance.CLOSE;
        d61.spawnAngle = 23;

        Data d62 = new Data();
        d62.time = 129328;
        d62.spawnTime = 1000;
        d62.distance = Distance.CLOSE;
        d62.spawnAngle = 37;

        Data d63 = new Data();
        d63.time = 131179;
        d63.spawnTime = 1000;
        d63.distance = Distance.CLOSE;
        d63.spawnAngle = 55;

        Data d64 = new Data();
        d64.time = 133018;
        d64.spawnTime = 1000;
        d64.distance = Distance.CLOSE;
        d64.spawnAngle = 16;

        Data d65 = new Data();
        d65.time = 134866;
        d65.spawnTime = 1000;
        d65.distance = Distance.CLOSE;
        d65.spawnAngle = 11;

        Data d66 = new Data();
        d66.time = 136695;
        d66.spawnTime = 1000;
        d66.distance = Distance.CLOSE;
        d66.spawnAngle = 71;

        Data d67 = new Data();
        d67.time = 138601;
        d67.spawnTime = 1000;
        d67.distance = Distance.CLOSE;
        d67.spawnAngle = 2;

        Data d68 = new Data();
        d68.time = 140340;
        d68.spawnTime = 1000;
        d68.distance = Distance.CLOSE;
        d68.spawnAngle = 74;

        Data d69 = new Data();
        d69.time = 142263;
        d69.spawnTime = 1000;
        d69.distance = Distance.CLOSE;
        d69.spawnAngle = 52;

        Data d70 = new Data();
        d70.time = 144150;
        d70.spawnTime = 1000;
        d70.distance = Distance.CLOSE;
        d70.spawnAngle = 89;

        Data d71 = new Data();
        d71.time = 145922;
        d71.spawnTime = 1000;
        d71.distance = Distance.CLOSE;
        d71.spawnAngle = 26;

        Data d72 = new Data();
        d72.time = 147819;
        d72.spawnTime = 1000;
        d72.distance = Distance.CLOSE;
        d72.spawnAngle = 28;

        Data d73 = new Data();
        d73.time = 149757;
        d73.spawnTime = 1000;
        d73.distance = Distance.CLOSE;
        d73.spawnAngle = 62;

        Data d74 = new Data();
        d74.time = 151554;
        d74.spawnTime = 1000;
        d74.distance = Distance.CLOSE;
        d74.spawnAngle = 27;

        Data d75 = new Data();
        d75.time = 153384;
        d75.spawnTime = 1000;
        d75.distance = Distance.CLOSE;
        d75.spawnAngle = 1;

        Data d76 = new Data();
        d76.time = 155224;
        d76.spawnTime = 1000;
        d76.distance = Distance.CLOSE;
        d76.spawnAngle = 67;

        Data d77 = new Data();
        d77.time = 157034;
        d77.spawnTime = 1000;
        d77.distance = Distance.CLOSE;
        d77.spawnAngle = 63;

        Data d78 = new Data();
        d78.time = 158899;
        d78.spawnTime = 1000;
        d78.distance = Distance.CLOSE;
        d78.spawnAngle = 59;

        Data d79 = new Data();
        d79.time = 160702;
        d79.spawnTime = 1000;
        d79.distance = Distance.CLOSE;
        d79.spawnAngle = 55;

        Data d80 = new Data();
        d80.time = 162584;
        d80.spawnTime = 1000;
        d80.distance = Distance.CLOSE;
        d80.spawnAngle = 43;

        Data d81 = new Data();
        d81.time = 164457;
        d81.spawnTime = 1000;
        d81.distance = Distance.CLOSE;
        d81.spawnAngle = 36;

        Data d82 = new Data();
        d82.time = 166283;
        d82.spawnTime = 1000;
        d82.distance = Distance.CLOSE;
        d82.spawnAngle = 56;

        Data d83 = new Data();
        d83.time = 168132;
        d83.spawnTime = 1000;
        d83.distance = Distance.CLOSE;
        d83.spawnAngle = 23;

        Data d84 = new Data();
        d84.time = 169956;
        d84.spawnTime = 1000;
        d84.distance = Distance.CLOSE;
        d84.spawnAngle = 86;

        Data d85 = new Data();
        d85.time = 171815;
        d85.spawnTime = 1000;
        d85.distance = Distance.CLOSE;
        d85.spawnAngle = 8;

        Data d86 = new Data();
        d86.time = 177795;
        d86.spawnTime = 1000;
        d86.distance = Distance.CLOSE;
        d86.spawnAngle = 17;

        Data d87 = new Data();
        d87.time = 179209;
        d87.spawnTime = 1000;
        d87.distance = Distance.CLOSE;
        d87.spawnAngle = 37;

        Data d88 = new Data();
        d88.time = 181033;
        d88.spawnTime = 1000;
        d88.distance = Distance.CLOSE;
        d88.spawnAngle = 48;

        Data d89 = new Data();
        d89.time = 182904;
        d89.spawnTime = 1000;
        d89.distance = Distance.CLOSE;
        d89.spawnAngle = 29;

        Data d90 = new Data();
        d90.time = 184720;
        d90.spawnTime = 1000;
        d90.distance = Distance.CLOSE;
        d90.spawnAngle = 52;

        Data d91 = new Data();
        d91.time = 186548;
        d91.spawnTime = 1000;
        d91.distance = Distance.CLOSE;
        d91.spawnAngle = 85;

        Data d92 = new Data();
        d92.time = 188430;
        d92.spawnTime = 1000;
        d92.distance = Distance.CLOSE;
        d92.spawnAngle = 82;

        Data d93 = new Data();
        d93.time = 190242;
        d93.spawnTime = 1000;
        d93.distance = Distance.CLOSE;
        d93.spawnAngle = 69;

        Data d94 = new Data();
        d94.time = 192097;
        d94.spawnTime = 1000;
        d94.distance = Distance.CLOSE;
        d94.spawnAngle = 51;

        Data d95 = new Data();
        d95.time = 193967;
        d95.spawnTime = 1000;
        d95.distance = Distance.CLOSE;
        d95.spawnAngle = 51;

        Data d96 = new Data();
        d96.time = 195783;
        d96.spawnTime = 1000;
        d96.distance = Distance.CLOSE;
        d96.spawnAngle = 83;

        Data d97 = new Data();
        d97.time = 197688;
        d97.spawnTime = 1000;
        d97.distance = Distance.CLOSE;
        d97.spawnAngle = 22;

        Data d98 = new Data();
        d98.time = 199481;
        d98.spawnTime = 1000;
        d98.distance = Distance.CLOSE;
        d98.spawnAngle = 85;

        Data d99 = new Data();
        d99.time = 201339;
        d99.spawnTime = 1000;
        d99.distance = Distance.CLOSE;
        d99.spawnAngle = 86;

        Data d100 = new Data();
        d100.time = 203149;
        d100.spawnTime = 1000;
        d100.distance = Distance.CLOSE;
        d100.spawnAngle = 25;

        Data d101 = new Data();
        d101.time = 204983;
        d101.spawnTime = 1000;
        d101.distance = Distance.CLOSE;
        d101.spawnAngle = 51;

        Data d102 = new Data();
        d102.time = 208761;
        d102.spawnTime = 1000;
        d102.distance = Distance.CLOSE;
        d102.spawnAngle = 79;

        Data d103 = new Data();
        d103.time = 210537;
        d103.spawnTime = 1000;
        d103.distance = Distance.CLOSE;
        d103.spawnAngle = 65;

        Data d104 = new Data();
        d104.time = 212370;
        d104.spawnTime = 1000;
        d104.distance = Distance.CLOSE;
        d104.spawnAngle = 73;

        Data d105 = new Data();
        d105.time = 214224;
        d105.spawnTime = 1000;
        d105.distance = Distance.CLOSE;
        d105.spawnAngle = 7;

        Data d106 = new Data();
        d106.time = 216133;
        d106.spawnTime = 1000;
        d106.distance = Distance.CLOSE;
        d106.spawnAngle = 10;

        Data d107 = new Data();
        d107.time = 217988;
        d107.spawnTime = 1000;
        d107.distance = Distance.CLOSE;
        d107.spawnAngle = 62;

        Data d108 = new Data();
        d108.time = 219856;
        d108.spawnTime = 1000;
        d108.distance = Distance.CLOSE;
        d108.spawnAngle = 35;

        Data d109 = new Data();
        d109.time = 221665;
        d109.spawnTime = 1000;
        d109.distance = Distance.CLOSE;
        d109.spawnAngle = 66;

        Data d110 = new Data();
        d110.time = 223513;
        d110.spawnTime = 1000;
        d110.distance = Distance.CLOSE;
        d110.spawnAngle = 9;

        Data d111 = new Data();
        d111.time = 225342;
        d111.spawnTime = 1000;
        d111.distance = Distance.CLOSE;
        d111.spawnAngle = 58;

        Data d112 = new Data();
        d112.time = 227222;
        d112.spawnTime = 1000;
        d112.distance = Distance.CLOSE;
        d112.spawnAngle = 66;

        Data d113 = new Data();
        d113.time = 229023;
        d113.spawnTime = 1000;
        d113.distance = Distance.CLOSE;
        d113.spawnAngle = 29;

        Data d114 = new Data();
        d114.time = 230847;
        d114.spawnTime = 1000;
        d114.distance = Distance.CLOSE;
        d114.spawnAngle = 82;

        Data d115 = new Data();
        d115.time = 232786;
        d115.spawnTime = 1000;
        d115.distance = Distance.CLOSE;
        d115.spawnAngle = 34;

        Data d116 = new Data();
        d116.time = 234505;
        d116.spawnTime = 1000;
        d116.distance = Distance.CLOSE;
        d116.spawnAngle = 44;

        Data d117 = new Data();
        d117.time = 236385;
        d117.spawnTime = 1000;
        d117.distance = Distance.CLOSE;
        d117.spawnAngle = 38;

        Data d118 = new Data();
        d118.time = 238337;
        d118.spawnTime = 1000;
        d118.distance = Distance.CLOSE;
        d118.spawnAngle = 11;

        Data d119 = new Data();
        d119.time = 240072;
        d119.spawnTime = 1000;
        d119.distance = Distance.CLOSE;
        d119.spawnAngle = 62;

        Data d120 = new Data();
        d120.time = 241920;
        d120.spawnTime = 1000;
        d120.distance = Distance.CLOSE;
        d120.spawnAngle = 86;

        Data d121 = new Data();
        d121.time = 243828;
        d121.spawnTime = 1000;
        d121.distance = Distance.CLOSE;
        d121.spawnAngle = 39;

        Data d122 = new Data();
        d122.time = 245632;
        d122.spawnTime = 1000;
        d122.distance = Distance.CLOSE;
        d122.spawnAngle = 50;

        Data d123 = new Data();
        d123.time = 247544;
        d123.spawnTime = 1000;
        d123.distance = Distance.CLOSE;
        d123.spawnAngle = 52;

        Data d124 = new Data();
        d124.time = 249289;
        d124.spawnTime = 1000;
        d124.distance = Distance.CLOSE;
        d124.spawnAngle = 7;

        Data d125 = new Data();
        d125.time = 251155;
        d125.spawnTime = 1000;
        d125.distance = Distance.CLOSE;
        d125.spawnAngle = 35;

        MapInfo mapInfo = new MapInfo();
        mapInfo.name = "Firefly";
        mapInfo.song = "Jim Yosef - Firefly [NCS Release].mp3";
        mapInfo.songData = new Data[] { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22, d23, d24, d25, d26, d27, d28, d29, d30, d31, d32, d33, d34, d35, d36, d37, d38, d39, d40, d41, d42, d43, d44, d45, d46, d47, d48, d49, d50, d51, d52, d53, d54, d55, d56, d57, d58, d59, d60, d61, d62, d63, d64, d65, d66, d67, d68, d69, d70, d71, d72, d73, d74, d75, d76, d77, d78, d79, d80, d81, d82, d83, d84, d85, d86, d87, d88, d89, d90, d91, d92, d93, d94, d95, d96, d97, d98, d99, d100, d101, d102, d103, d104, d105, d106, d107, d108, d109, d110, d111, d112, d113, d114, d115, d116, d117, d118, d119, d120, d121, d122, d123, d124, d125, };

        return mapInfo;
    }
}
