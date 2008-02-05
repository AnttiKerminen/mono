namespace Db4objects.Db4o
{

        public interface IObjectContainer
        {
                System.Collections.IList Query ();
                System.Collections.Generic.IList<Extent> Query<Extent> ();
        }
}

namespace Db4objects.Db4o.Internal
{
        public abstract class ObjectContainerBase
        {
                public System.Collections.IList Query ()
                {
                        return null;
                }

                public System.Collections.Generic.IList<Extent> Query<Extent>()
                {
                        return null;
                }
        }

        public abstract class ExternalObjectContainer : ObjectContainerBase, IObjectContainer
        {
        }
		
		class M
		{
			public static void Main ()
			{
			}
		}
}
