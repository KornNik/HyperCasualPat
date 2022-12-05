using System.Collections.Generic;

namespace HyperCasual.Helpers
{
    sealed class AssetsPathCharacter
    {
        public static readonly Dictionary<CharacterTypes, string>
            CharactersPath = new Dictionary<CharacterTypes, string>
            {
                {CharacterTypes.PlayerOne, "Prefabs/Units/Prefabs_Units_PlayerOne" },
                {CharacterTypes.PlayerTwo,"Prefabs/Units/Prefabs_Units_PlayerTwo" }
            };
    }
}
