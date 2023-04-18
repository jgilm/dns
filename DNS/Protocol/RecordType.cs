namespace DNS.Protocol {
    public enum RecordType {
        A = 1,
        NS = 2,
        CNAME = 5,
        SOA = 6,
        WKS = 11,
        PTR = 12,
        MX = 15,
        TXT = 16,
        AAAA = 28,
        SRV = 33,
        OPT = 41,
        ANY = 255,

        // not yet implemented
        CAA = 257, // RFC 6844 https://datatracker.ietf.org/doc/html/rfc6844
        CDNSKEY = 60, // RFC 7344
        CDS = 59, // RFC 7344
        CERT = 37, // RFC 4398
        CSYNC = 62, // RFC 7477
        DHCID = 49, // RFC 4701
        DLV = 32769, // RFC 4431
        DNAME = 39, // RFC 6672
        DNSKEY = 48, // RFC 4034
        DS = 43, // RFC 4034
        HINFO = 13, // RFC 8482


    }
}
