Celkový čas strávený na hře (lze usoudit podle git logů) je asi 15-17h (10-12 mimo školu)

# Nedělní návrat

## 📌 Popis projektu

**Nedělní návrat** je 2D point & click logická adventura inspirovaná sérií her ve stylu Polda.

Hráč se probouzí po večírku v cizím domě a postupně zjišťuje, kde se nachází a jak se dostat ven. Cílem je opustit dům pomocí interakce s prostředím, sbírání předmětů a řešení logických hádanek.

Hra kombinuje klasické adventurní prvky (klíče, zamčené objekty, průzkum místností) s méně zřejmými logickými indiciemi v prostředí.

---

## 🎯 Cíl hry

Hráč se musí dostat z domu ven.

Možnosti:

- odemknout hlavní dveře pomocí číselného kódu (skrytá logická hádanka)
- nebo najít alternativní cestu k úniku

Kód k hlavním dveřím je skryt v prostředí a skládá se z více vizuálních indicií.

---

## 🧩 Herní principy

- point & click interakce
- prozkoumávání místností
- sbírání a používání předmětů
- logické hádanky a skládání indicií
- více interaktivních objektů v každé místnosti

---

## 🏠 Struktura hry

Hra obsahuje propojené místnosti:

- obývací pokoj
- kuchyň
- chodba

Každá místnost obsahuje klikatelné objekty (např. skříňky, spotřebiče, dveře), které skrývají:

- předměty do inventáře
- textové nápovědy
- logické stopy ke kódu

---

## 🔐 Hlavní hádanka (kódové dveře)

Hlavní dveře jsou zamčené číselným zámkem.

- kód je 3místný (např. 137)
- čísla jsou skrytá v prostředí
- hráč musí spojit vizuální nápovědy
- pořadí může být variabilní (logická kombinace)

---

## 🎒 Inventář

Hráč může sbírat předměty, které:

- slouží k odemykání dalších částí hry
- ovlivňují dialogy a interakce
- ukládají se do jednoduchého interního systému (GameState)

Inventář je záměrně jednoduchý (boolean stavové proměnné).

---

## 💾 Ukládání hry

Hra podporuje ukládání a načítání stavu:

- save se ukládá do `.txt` souborů
- obsahuje stav inventáře a klíčové informace
- umožňuje více save slotů
- podporuje mazání a výběr save souborů

---

## 🖥️ Technické řešení

- Jazyk: C#
- Framework: .NET 8
- UI: WPF (Windows Presentation Foundation)
- Architektura:
  - Pages (herní obrazovky)
  - Windows (popup dialogy)
  - GameState (logika hry)
  - Inventory (stav předmětů)

### Navigace

Hra využívá `Frame` pro přepínání mezi stránkami (Page).

### Dialogy

Popup okna jsou řešena pomocí `ShowDialog()`.

---

## 📁 Struktura projektu

- /Pages – herní místnosti a menu
- /messages – popup okna a dialogy
- /img – grafické assety (pozadí místností)
- GameState.cs – logika hry a ukládání
- Inventory.cs – stav předmětů

---

## 🎨 Grafika

Hra používá statické obrázky jako pozadí:

- menu.png
- livingroom.png
- kitchen.png
- hall.png

Na tyto obrázky jsou vrstveny transparentní klikací oblasti (tlačítka).

---

## ⚙️ Implementované prvky

- hlavní menu
- přepínání místností
- interaktivní objekty (skříně, spotřebiče, dveře)
- popup dialogy s textem
- inventář
- ukládání a načítání hry
- escape menu (pauza)

---

## 🧠 Herní design

Hra je navržena jako:

- krátká logická adventura
- důraz na pozorování detailů
- jednoduchá, ale kombinatorická logika
- více způsobů interpretace indicií

---

## 📅 Časový plán vývoje

- vytvoření konceptu a scénáře
- návrh struktury místností
- implementace WPF UI
- implementace logiky interakcí
- systém inventáře
- save/load systém
- testování a ladění

---

## 🧪 Možná rozšíření

- více místností
- více alternativních konců
- zvukové efekty
- vizuální animace objektů
- složitější hádanky

---

## 🎓 Soulad se zadáním ročníkové práce

Projekt splňuje požadavky:

- obsahuje logické puzzle prvky
- hráč řeší problém (únik z domu)
- hra není jen klikací prezentace
- obsahuje interakci s prostředím
- využívá postupné odhalování informací
- má jasný cíl a strukturu

Rozsah odpovídá časovým možnostem vývoje.

---

## 👤 Autor

Student ročníkové práce

---

## 📝 Poznámka

Projekt je školní práce inspirovaná adventurním stylem her typu Polda. Cílem bylo vytvořit funkční logickou hru s důrazem na interakci, prostředí a řešení hádanek.
