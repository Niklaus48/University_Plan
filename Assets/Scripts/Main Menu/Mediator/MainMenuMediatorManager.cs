using System;
using UnityEngine;
using Zenject;

namespace Main_Menu.Mediator
{
    public class MainMenuMediatorManager
    {
        private static DiContainer _container;
        
        public static void Initialize(DiContainer container)
        {
            _container = container;
        }
        
        public static TOutput Invoke<TInput, TOutput>(TInput input)
        {
            var handlerType = typeof(IMainMenuMediatorHandler<TInput, TOutput>);
            var handler = _container.Resolve(handlerType);

            if (handler is IMainMenuMediatorHandler<TInput, TOutput> mediator)
            {
                return mediator.handle(input);
            }
            
            throw new Exception($"No mediator found for input type {typeof(TInput)}");
        }
    }
}