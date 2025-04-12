namespace Main_Menu.Mediator
{
    public interface IMainMenuMediatorHandler<TInput, TOutput>
    {
        TOutput handle(TInput input);
    }
}