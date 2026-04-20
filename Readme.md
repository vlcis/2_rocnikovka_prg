17. 04. 2026
Vytvoření projektu  (5min)
Zopakovaní základních git funkcí a příkazů (35 min)
Zjištění co je hra Polda (30min)
Rozhododnutí o struktuře (15min)

Struktura, kterou pravděpodobně změním:
# Nedělní návrat

## Popis projektu

**Nedělní návrat** je krátká 2D point & click hra inspirovaná logickými adventurami ve stylu série Polda.

Hráč se probouzí po večírku v cizím domě, aniž by věděl, kde se nachází nebo jak se tam dostal. Cílem hry je dostat se ven pomocí interakce s prostředím, sbírání předmětů a řešení logických hádanek.

Hra kombinuje klasické prvky (klíče, zamčené dveře) s méně zřejmými logickými úkoly a nabízí více způsobů, jak dosáhnout cíle.

---

## Herní principy

* point & click ovládání
* interakce s objekty v prostředí
* sbírání a používání předmětů
* logické hádanky
* více možných řešení

---

## Cíl hry

Dostat se z domu ven.

Hráč může:

* uniknout **oknem** (jednodušší cesta)
* nebo odemknout **hlavní dveře pomocí číselného kódu** (obtížnější cesta)

---

## Herní mechaniky

### Inventář

Hráč může sbírat předměty (např. klíče), které slouží k odemykání dalších částí domu.

### Postup

* hráč postupně odemyká nové místnosti
* získává nové informace a předměty
* skládá si obraz o situaci

### Hádanky

Ve hře se nachází dva typy hádanek:

1. **Přímé (lineární)**

   * např. nalezení klíče a odemčení dveří

2. **Nepřímé (skryté)**

   * kombinování nenápadných informací z prostředí
   * vyžadují pozornost a logické uvažování

---

## Náročná hádanka (číselný kód)

Hlavní dveře jsou zamčené číselným zámkem.

Kód není přímo sdělen, ale je skryt v prostředí:

* čísla se nachází v různých objektech (např. hodiny, poznámky, detaily v místnosti)
* hráč musí tyto informace spojit

Tato hádanka je záměrně obtížná a není nutná pro dokončení hry.

---

## Struktura hry

Hra obsahuje několik propojených místností:

* obývací pokoj
* kuchyň
* chodba

Každá místnost obsahuje interaktivní objekty, které posouvají hráče dál.

---

## Konec hry

Po opuštění domu (oknem nebo dveřmi) hráč zjistí, že:

> se nachází u sousedů a do domu se dostal vlastní chybou.

---

## Použité technologie

Projekt je vytvořen v jazyce:

* Python

Možné knihovny:

* pygame (pro grafiku a vstup)

---

## Důvod volby technologie

Python byl zvolen z následujících důvodů:

* rychlá implementace
* jednoduchá syntaxe
* vhodnost pro menší 2D projekty
* dostatečné možnosti pro práci s grafikou a vstupem

Cílem bylo soustředit se především na herní logiku, nikoliv na složitou technickou implementaci.

---

## Rozsah projektu

Rozsah hry odpovídá časovým možnostem (cca 12–20 hodin práce).

Projekt se zaměřuje na:

* funkčnost
* logickou strukturu
* herní zážitek

Nikoli na:

* pokročilou grafiku
* rozsáhlý obsah

---

## Možná rozšíření

* více místností
* více předmětů
* další alternativní konce
* zvukové efekty

---

## Autor

[TVÉ JMÉNO]

---

## Poznámka

Projekt je školní práce vytvořená za účelem demonstrace základních principů návrhu jednoduché hry a implementace herní logiky.
