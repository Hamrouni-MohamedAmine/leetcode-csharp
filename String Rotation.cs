public static bool isSubstring (string ch, string substring) {
    return ch.Contains (substring);
}

public static bool isRotation (string ch, string ch2) {
    var chch = ch + ch;
    if (isSubstring (chch, ch2))
        return true;
    else return false;
}