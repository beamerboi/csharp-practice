# I giocattoli di Jedlik

Ti diamo il benvenuto a I giocattoli di Jedlik, nella traccia C# di Exercism.
Se hai bisogno di aiuto per eseguire i test o per inviare il codice, consulta `HELP.md`.
Se ti blocchi sull'esercizio, consulta `HINTS.md`, ma prima prova a risolverlo senza usarli :)

## Introduction

## Classi

Il principale costrutto orientato agli oggetti in C# è la _classe_, che combina dati (_campi_) e comportamento (_metodi_). I campi e i metodi di una classe sono noti come i suoi _membri_.

L'accesso ai membri può essere limitato tramite i modificatori di accesso, dei quali i due più comuni sono:

- `public`: il membro è accessibile da qualsiasi codice (nessuna restrizione).
- `private`: il membro è accessibile solo dal codice nella stessa classe.

Puoi pensare a una classe come a un modello per creare istanze di quella classe. Per creare un'istanza di una classe (nota anche come _oggetto_), si usa la keyword `new`:

```csharp
class Car
{
}

// Create two car instances
var myCar = new Car();
var yourCar = new Car();
```

I campi hanno un tipo e possono essere definiti ovunque all'interno di una classe.
I campi pubblici si definiscono in PascalCase, mentre quelli privati si definiscono in camelCase e sono preceduti da un underscore `_`:

```csharp
class Car
{
    // Accessible by anyone
    public int Weight;

    // Only accessible by code in this class
    private string _color;
}
```

È possibile assegnare facoltativamente un valore iniziale a un campo. Se un campo _non_ specifica un valore iniziale, viene impostato al valore predefinito del suo tipo. I valori dei campi di un'istanza possono essere letti e aggiornati usando la notazione con il punto.

```csharp
class Car
{
    // Will be set to specified value
    public int Weight = 2500;

    // Will be set to default value (0)
    public int Year;
}

var newCar = new Car();
newCar.Weight; // => 2500
newCar.Year;   // => 0

// Update value of the field
newCar.Year = 2018;
```

I campi privati vengono di solito aggiornati come effetto collaterale della chiamata a un metodo. Tali metodi di solito non restituiscono alcun valore, nel qual caso il tipo restituito dovrebbe essere `void`:

```csharp
class CarImporter
{
    private int _carsImported;

    public void ImportCars(int numberOfCars)
    {
        // Update private field from public method
        _carsImported = _carsImported + numberOfCars;
    }
}
```

## Instructions

In questo esercizio giocherai con un'auto radiocomandata, che finalmente hai risparmiato abbastanza soldi per comprare.

Le auto partono con la batteria completamente carica (100%). Ogni volta che guidi l'auto con il radiocomando, percorre 20 metri e consuma l'uno per cento della batteria.

L'auto radiocomandata ha un elegante display a LED che mostra due informazioni:

- La distanza totale percorsa, visualizzata come: `"Driven <METERS> meters"`.
- La carica residua della batteria, visualizzata come: `"Battery at <PERCENTAGE>%"`.

Se la batteria è allo 0%, non puoi più guidare l'auto e il display della batteria mostrerà `"Battery empty"`.

Ci sono sei attività da svolgere, ognuna delle quali lavorerà con istanze di auto radiocomandata.

## 1. Compra un'auto radiocomandata nuova di zecca

Implementa il metodo (_statico_) `RemoteControlCar.Buy()` per restituire un'istanza nuova di zecca di auto radiocomandata:

```csharp
RemoteControlCar car = RemoteControlCar.Buy();
```

## 2. Mostra la distanza percorsa

Implementa il metodo `RemoteControlCar.DistanceDisplay()` per restituire la distanza così come viene visualizzata sul display a LED:

```csharp
var car = RemoteControlCar.Buy();
car.DistanceDisplay();
// => "Driven 0 meters"
```

## 3. Mostra la percentuale della batteria

Implementa il metodo `RemoteControlCar.BatteryDisplay()` per restituire la percentuale della batteria così come viene visualizzata sul display a LED:

```csharp
var car = RemoteControlCar.Buy();
car.BatteryDisplay();
// => "Battery at 100%"
```

## 4. Aggiorna il numero di metri percorsi quando guidi

Implementa il metodo `RemoteControlCar.Drive()` che aggiorna il numero di metri percorsi:

```csharp
var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.DistanceDisplay();
// => "Driven 40 meters"
```

## 5. Aggiorna la percentuale della batteria quando guidi

Aggiorna il metodo `RemoteControlCar.Drive()` per aggiornare la percentuale della batteria:

```csharp
var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.BatteryDisplay();
// => "Battery at 98%"
```

## 6. Impedisci di guidare quando la batteria è scarica

Aggiorna il metodo `RemoteControlCar.Drive()` in modo che non aumenti la distanza percorsa né diminuisca la percentuale della batteria quando la batteria è scarica (allo 0%):

```csharp
var car = RemoteControlCar.Buy();

// Drain the battery
// ...

car.DistanceDisplay();
// => "Driven 2000 meters"

car.BatteryDisplay();
// => "Battery empty"
```

## Source

### Created by

- @ErikSchierboom

### Contributed to by

- @yzAlvin