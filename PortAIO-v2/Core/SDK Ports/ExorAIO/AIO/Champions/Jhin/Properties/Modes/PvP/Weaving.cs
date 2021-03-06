
#pragma warning disable 1587

using EloBuddy; 
using LeagueSharp.SDK; 
namespace ExorAIO.Champions.Jhin
{
    using ExorAIO.Utilities;

    using LeagueSharp;
    using LeagueSharp.SDK;
    using LeagueSharp.SDK.UI;
    using LeagueSharp.SDK.Utils;

    /// <summary>
    ///     The logics class.
    /// </summary>
    internal partial class Logics
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Called on do-cast.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="GameObjectProcessSpellCastEventArgs" /> instance containing the event data.</param>
        public static void Weaving(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (!(args.Target is AIHeroClient) || Invulnerable.Check((AIHeroClient)args.Target))
            {
                return;
            }

            /// <summary>
            ///     The Q Weaving Logic.
            /// </summary>
            if (Vars.Q.IsReady() && ((AIHeroClient)args.Target).IsValidTarget(Vars.Q.Range)
                && Vars.Menu["spells"]["q"]["combo"].GetValue<MenuBool>().Value
                && !Vars.Menu["spells"]["q"]["reloadcombo"].GetValue<MenuBool>().Value)
            {
                Vars.Q.CastOnUnit((AIHeroClient)args.Target);
            }
        }

        #endregion
    }
}