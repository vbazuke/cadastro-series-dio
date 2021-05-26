using System;
using System.Collections.Generic;
using System.Linq;
using Flix.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Flix
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		private SerieContext _context { get; set; }
		public SerieRepositorio(SerieContext context)
		{
			_context = new SerieContext();
		}

		public void Atualiza(int id, Serie objeto)
		{			
			var entity = _context.Serie.Find(id);

			if (entity == null)
			{
				return;
			}

			_context.Entry(entity).CurrentValues.SetValues(objeto);
			_context.SaveChanges();
			
		}

		public void Exclui(int id)
		{
			var entity = _context.Serie.Find(id);

			if (entity == null)
			{
				return;
			}

			entity.Excluido = true;
			_context.SaveChanges();
		}

		public void Insere(Serie objeto)
		{
			_context.Add(objeto);
			_context.SaveChanges();
		}

		public List<Serie> Lista()
		{
			return _context.Serie.ToList();
		}

		public int ProximoId()
		{
            return _context.Serie.Count() + 1;
		}

		public Serie RetornaPorId(int id)
		{
			return _context.Serie.Find(id);
		}
	}
}