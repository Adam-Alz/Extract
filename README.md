# Extract ??

Assistant HUD ultra-léger et externe pour la reconnaissance d'objets et l'estimation de valeur en temps réel.

## ? Spécifications Techniques
- **Performance** : Chaîne complète (Capture ROI, binarisation OpenCV, OCR) sous les 50 ms.
- **Overlay Non-Intrusif** : Interface WPF transparente avec style passthrough (WS_EX_TRANSPARENT / WS_EX_NOACTIVATE).
- **Sécurité Anti-Cheat** : 100% externe. Aucun accès mémoire (ReadProcessMemory), capture passive des pixels Windows (GDI/DXGI).
- **Stack** : C# .NET 10 | WPF | OpenCvSharp4 | Tesseract | SQLite.

## ??? Architecture de la Solution
- src/Extract.UI : Fenêtrage WPF, gestion du rendu HUD et interopérabilité Win32.
- src/Extract.Core : Logique métier (hooks clavier bas niveau, vision par ordinateur, cache SQLite et appels API).
