17. 04. 2026
Vytvoření projektu  (5min)
Zopakovaní základních git funkcí a příkazů (35 min)
Zjištění co je hra Polda (30min)
Rozhododnutí o struktuře (15min)

Struktura, kterou pravděpodobně změním:
# Případ ztraceného USB

## Základní informace
Krátká textová point-and-click adventura inspirovaná sérií Polda.  
Hra je navržena jako jednoduchý školní projekt s minimální grafikou a jedním levelem.

---

## Příběh
Hlavní postava je policista / IT „detektiv“, který řeší banální případ:  
někomu ve škole zmizel USB disk s důležitým projektem.

Během vyšetřování:
- vyslýchá 3–4 podezřelé (spolužáci / učitel)
- zjišťuje, že každý něco skrývá
- postupně získává předměty a informace

### Twist
USB není ukradené — někdo ho „zabavil“, protože obsah byl podezřelý / trapný / nelegální.

### Konec
Hráč odhalí viníka a rozhodne se:
- vrátit USB
- nebo ho nechat zmizet

---

## Struktura hry
- 1 level (jedna obrazovka – např. učebna)
- žádný pohyb mezi lokacemi

### Klikatelné prvky
- postavy (NPC)
- objekty (skříňka, počítač, batoh, koš…)

---

## Herní funkce

### 1. Interakce s objekty
- kliknutí zobrazí text (komentář postavy)
- někdy hráč získá předmět

**Příklad:**
> „Tohle je koš. Smrdí. Asi do něj sahat nebudu… no dobře, budu.“

---

### 2. Inventář
- textový seznam předmětů
- možnosti:
  - použít předmět
  - kombinovat předměty (omezeně)

---

### 3. Dialogy
- kliknutí na postavu otevře dialogové možnosti
- jednoduché otázky:
  - „Zeptej se na USB“
  - „Zeptej se na alibi“
  - „Ukaž předmět“

- nové dialogy se odemykají podle postupu ve hře

---

### 4. Postup hrou
Hráč musí:
- získat informace
- najít 2–3 klíčové předměty
- odemknout finální dialog

---

### 5. Finální volba
Na konci hry:
- „Obvinit X“
- „Zamlčet případ“

---

## Obsah hry

### Postavy (max 4)
- Hráč (detektiv)
- Podezřelý 1 (divný spolužák)
- Podezřelý 2 (učitel)
- Podezřelý 3 (tichý typ)

---

### Předměty (5–8)
- USB (klíčový předmět)
- klíč
- papír s heslem
- mobil
- vtipný / zbytečný předmět

---

### Puzzly (3–5)
- najít klíč → otevřít skříňku
- zjistit heslo → otevřít soubor
- použít předmět v dialogu

---

## Grafika
Minimalistická:
- 1 pozadí (obrázek nebo barva)
- postavy:
  - statické obrázky nebo textová tlačítka
- inventář jako textový seznam