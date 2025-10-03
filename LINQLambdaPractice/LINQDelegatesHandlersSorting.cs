// LINQ
  // example
  var evens = numbers.Where(n => n % 2 == 0);
  // use case
  var results = products
    .Where(p => p.Price < 100)
    .Where(p => p.InStock)
    .OrderBy(p => p.Rating)
    .Take(10);
// delegates
  // example
  Func<int, int> square = x => x * x;  
  int result = square(5);
  // use case
  void ApplyDamage(Enemy enemy, Func<int, int> damageCalculator) 
  {
    enemy.Health -= damageCalculator(enemy.Armor);
  }
  ApplyDamage(enemy, armor => 50);
  ApplyDamage(enemy, armor => Math.Max(0, 50 - armor));
// eventhandlers
  // example
  public class Button 
  {
      public event EventHandler Clicked;
      
      public void Click() 
      {
          Clicked?.Invoke(this, EventArgs.Empty); 
      }
  }
  button.Clicked += (s, e) => Console.WriteLine("User 1 knows!");
  button.Clicked += (s, e) => Console.WriteLine("User 2 knows too!");
  // use case
  saveButton.Clicked += (s, e) => SaveData();
  saveButton.Clicked += (s, e) => ShowConfirmation();
  saveButton.Clicked += (s, e) => LogActivity();
// sorting
  // example
  people.Sort((a, b) => a.Age.CompareTo(b.Age));
  // use case
  players.Sort((a, b) => 
  {
    int scoreCompare = b.Score.CompareTo(a.Score);  
    if (scoreCompare != 0) return scoreCompare;
    return a.Time.CompareTo(b.Time);  
  });

// linq would be better for complex sorting ^
var ranked = players
    .OrderByDescending(p => p.Score)
    .ThenBy(p => p.Time)
    .ToList();
