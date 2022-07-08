using System;

namespace Gerenciamento.Matricula.API.Domain.Entities
{
    public class Aluno
    {
        /// <summary>
        /// Id de identificação do aluno.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do aluno.
        /// </summary>
        public string NomeCompleto { get; set; }

        /// <summary>
        /// Data da Matrícula do aluno.
        /// </summary>
        public DateTime DataDaMatricula { get; set; }
    }
}
