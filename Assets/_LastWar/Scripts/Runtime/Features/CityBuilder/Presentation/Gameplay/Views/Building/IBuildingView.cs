namespace _LastWar.CityBuilder.Presentation.Gameplay.Views.Building
{
    public interface IBuildingView
    {
        void Initialize();
        void SetSelected(bool selected);
        void Move();
        void Upgrade();
        void Remove();
    }
}