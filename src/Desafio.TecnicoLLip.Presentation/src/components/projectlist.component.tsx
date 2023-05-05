import { Component } from "react";
import ProjectService from "../services/project.service";

type Props = {};

type Projects = { id: number, titulo: string, descricao: string, dataCriacao: Date };

type State = { data: Array<Projects>, redirect: string | null };

export type Person = {
  firstName: string;
  lastName: string;
  address: string;
  city: string;
  state: string;
  subRows?: Person[]; //Each person can have sub rows of more people
};

export const data = [
  {
    firstName: 'Dylan',
    lastName: 'Murray',
    address: '261 Erdman Ford',
    city: 'East Daphne',
    state: 'Kentucky',
    subRows: [
      {
        firstName: 'Ervin',
        lastName: 'Reinger',
        address: '566 Brakus Inlet',
        city: 'South Linda',
        state: 'West Virginia',
        subRows: [
          {
            firstName: 'Jordane',
            lastName: 'Homenick',
            address: '1234 Brakus Inlet',
            city: 'South Linda',
            state: 'West Virginia',
          },
        ],
      },
      {
        firstName: 'Brittany',
        lastName: 'McCullough',
        address: '722 Emie Stream',
        city: 'Lincoln',
        state: 'Nebraska',
      },
    ],
  },
  {
    firstName: 'Raquel',
    lastName: 'Kohler',
    address: '769 Dominic Grove',
    city: 'Columbus',
    state: 'Ohio',
    subRows: [
      {
        firstName: 'Branson',
        lastName: 'Frami',
        address: '32188 Larkin Turnpike',
        city: 'Charleston',
        state: 'South Carolina',
      },
    ],
  },
];

export default class ProjectList extends Component<Props, State> {
  constructor(props: Props) {

    super(props);

      this.handleRegister();

      this.state = { data: [], redirect: null };

  }

  handleRegister() {

      ProjectService.listar()
          .then(response => {
              if (response) {
                this.setState({
                    data: response.data
                });
            }
      },
      error => {
        const resMessage =
          (error.response &&
            error.response.data &&
            error.response.data.message) ||
          error.message ||
          error.toString();        
      }
    );
  }

  render() {
    const { data } = this.state;

    return (
      <div className="col-md-12">
        <div className="card card-container"> 
                <table>
                    <tr>
                        <td>
                            <button onClick={e => window.location.href = '/project'}>Novo</button>
                        </td>
                    </tr>
                </table> 
                <table>
                    <tr>
                        <td>Título</td>
                        <td>Descrição</td>
                        <td>Data de Criação</td>
                    </tr>
                </table> 
                {data.map((reg, index) => {
                return (
                    <div key={index}>
                        <table>
                            <tr>
                                <td>{reg.titulo}</td>
                                <td>{reg.descricao}</td>
                                <td>{reg.dataCriacao.toString()}</td>
                                <td>
                                    <button onClick={e => window.location.href='/project'}>Tarefas</button>
                                </td>
                            </tr>
                        </table>
                    </div>
                );
            })}       
        </div>
      </div>
    );
  }
}
