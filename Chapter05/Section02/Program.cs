﻿using System.Security.Cryptography.X509Certificates;

namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            var appVer1 = new AppVersion(5, 1);
            var appVer2 = new AppVersion(5, 1);

            if (appVer1 == appVer2) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
        }
    }
    public record AppVersion(int m, int mi, int b = 0, int r = 0) {
        public int Major { get; init; } = m;
        public int Minor { get; init; } = mi;
        public int Build { get; init; } = b;
        public int Revision { get; init; } = r;

        public override string ToString() =>
            $"{Major}.{Minor}.{Build}.{Revision}";
    }
}


//            public AppVersion(int major, int minor)
//                    : this(major, minor, 0, 0) {
//            }
//            public AppVersion(int major, int minor, int build)
//                    : this(major, minor, 0, 0) {
//            }
//            public AppVersion(int major, int minor, int build, int revision) {
//                Major = major;
//                Minor = minor;
//                Build = build;
//                Revision = revision;
//            }
//        }
//    }

