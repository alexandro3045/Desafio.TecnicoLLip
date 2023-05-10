import { Component } from "react";
import GridPopup from "./gridpopup";
import ProjectService from "../services/project.service";

type Props = {};

type Projects = { id: number, titulo: string, descricao: string, dataCriacao: Date };

type State = { data: Array<Projects>, redirect: string | null };

export default class Popup extends Component<Props, State> {
  constructor(props: Props) {

    super(props);

      this.state = { data: [], redirect: null };

      this.handleRegister();
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
        // rome-ignore lint/complexity/useOptionalChain: <explanation>
        (error.response &&
          error.response.data &&
          error.response.data.message) ||
        error.message ||
        error.toString();     
        console.log('error:',resMessage);   
    }
  );
}

  render() {
    return (
      <GridPopup/>          
    );
  }
}